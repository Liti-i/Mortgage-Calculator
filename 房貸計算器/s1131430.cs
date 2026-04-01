using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 房貸計算器
{
    public partial class s1131430 : Form
    {
        // Placeholder 色彩與活動色
        private readonly Color PlaceholderColor = Color.DarkGray;
        private readonly Color ActiveColor = SystemColors.WindowText;

        // 自訂 Enter 導覽順序（明確列出，避免 TabOrder/容器造成跳過）
        private Control[] enterOrder;

        public s1131430()
        {
            InitializeComponent();

            // 綁定事件
            this.Resetbtn.Click += Resetbtn_Click;
            this.Pricecheck.CheckedChanged += DownPaymentModeChanged;
            this.Percentagecheck.CheckedChanged += DownPaymentModeChanged;
            this.Calbtn.Click += Calbtn_Click;

            // 註冊輸入框的 focus 事件以實作提示文字（placeholder）
            RegisterPlaceholder(Totaltxt, "單位:新台幣(NTD)");
            RegisterPlaceholder(textBox6, "單位:新台幣(NTD)");
            RegisterPlaceholder(textBox7, "百分比(%)");
            RegisterPlaceholder(Annualtxt, "百分比(%)");
            RegisterPlaceholder(Loantxt, "單位為年");
            RegisterPlaceholder(Gracetxt, "單位為年");

            // 建立 Enter 跳格的順序並綁定事件
            BuildEnterNavigationOrder();
            AttachEnterKeyNavigation();

            // 初始為比例輸入預設
            this.Percentagecheck.Checked = true;
            UpdateDownPaymentInputs();
        }

        private void Totallbl_Click(object sender, EventArgs e)
        {
            // 不需要處理
        }

        private void Calbtn_Click(object sender, EventArgs e)
        {
            // 讀取並驗證輸入
            if (!TryParseDouble(Totaltxt.Text, out double totalPrice) || totalPrice <= 0)
            {
                MessageBox.Show("請輸入有效的房屋總價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 取得自備款 (依選擇)
            double downPayment = 0.0;
            if (Pricecheck.Checked)
            {
                // 使用金額
                if (!TryParseDouble(textBox6.Text, out downPayment) || downPayment < 0)
                {
                    MessageBox.Show("請輸入有效的自備款金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // 使用比例
                if (!TryParseDouble(textBox7.Text, out double downPercent) || downPercent < 0)
                {
                    MessageBox.Show("請輸入有效的自備款比例(%)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                downPayment = totalPrice * downPercent / 100.0;
            }

            if (downPayment >= totalPrice)
            {
                MessageBox.Show("自備款不可大於或等於房屋總價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 年利率
            if (!TryParseDouble(Annualtxt.Text, out double annualRate) || annualRate < 0)
            {
                MessageBox.Show("請輸入有效的年利率(%)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 貸款年限（年）
            if (!TryParseDouble(Loantxt.Text, out double loanYearsDouble) || loanYearsDouble <= 0)
            {
                MessageBox.Show("請輸入有效的貸款年限(年)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int loanYears = (int)Math.Round(loanYearsDouble);
            int totalMonths = loanYears * 12;

            // 寬限期（年，選填）
            int graceYears = 0;
            if (!IsPlaceholderOrEmpty(Gracetxt.Text))
            {
                if (!int.TryParse(Gracetxt.Text, out graceYears) || graceYears < 0)
                {
                    MessageBox.Show("請輸入有效的寬限期(年)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int graceMonths = graceYears * 12;

            // 若寬限期超過或等於總期數，視為全期僅繳利息（不攤還本金）
            int amortMonths = totalMonths - graceMonths;
            bool fullInterestOnly = false;
            if (amortMonths <= 0)
            {
                amortMonths = totalMonths;
                graceMonths = totalMonths;
                fullInterestOnly = true;
            }

            double loanAmount = totalPrice - downPayment; // 貸款本金（原始）
            double monthlyRate = annualRate / 100.0 / 12.0;

            // 計算寬限期間每月只繳利息（本金不動）
            double monthlyInterestOnlyPayment = loanAmount * monthlyRate;
            double totalInterest = 0.0;
            double totalRepayment = 0.0;
            double monthlyPayment = 0.0; // 本息攤還期的每月本息金額
            double firstPaymentInterest = 0.0;
            double firstPaymentPrincipal = 0.0;

            // 先計算寬限期利息總和
            totalInterest += monthlyInterestOnlyPayment * graceMonths;
            totalRepayment += monthlyInterestOnlyPayment * graceMonths;

            if (fullInterestOnly)
            {
                // 全期皆為利息，沒有本金攤還
                monthlyPayment = monthlyInterestOnlyPayment;
                firstPaymentInterest = monthlyInterestOnlyPayment;
                firstPaymentPrincipal = 0.0;
            }
            else
            {
                // 計算攤還期每月本息（年金公式）
                if (Math.Abs(monthlyRate) < 1e-12)
                {
                    // 無利率
                    monthlyPayment = loanAmount / amortMonths;
                }
                else
                {
                    double pow = Math.Pow(1 + monthlyRate, amortMonths);
                    monthlyPayment = loanAmount * monthlyRate * pow / (pow - 1);
                }

                // 模擬每月攤還以累計利息（避免公式四捨五入誤差）
                double remainingPrincipal = loanAmount;
                for (int m = 1; m <= amortMonths; m++)
                {
                    double interestPayment = remainingPrincipal * monthlyRate;
                    double principalPayment = monthlyPayment - interestPayment;

                    // 最後一個月可能小於計算值的修正
                    if (m == amortMonths)
                    {
                        principalPayment = remainingPrincipal;
                        monthlyPayment = principalPayment + interestPayment;
                    }

                    remainingPrincipal -= principalPayment;
                    totalInterest += interestPayment;
                    totalRepayment += principalPayment + interestPayment;

                    if (m == 1)
                    {
                        firstPaymentInterest = interestPayment;
                        firstPaymentPrincipal = principalPayment;
                    }
                }
            }

            // 填回結果欄位（使用系統文化格式化數字）
            var ci = CultureInfo.CurrentCulture;
            TotalOuttxt.Text = loanAmount.ToString("N2", ci); // 貸款總金額
            MonthOuttxt.Text = monthlyPayment.ToString("N2", ci); // 每月本+息 (攤還期的金額；若全期利息則為利息)
            FirstOuttxt.Text = string.Format(ci, "利息: {0}  本金: {1}", firstPaymentInterest.ToString("N2", ci), firstPaymentPrincipal.ToString("N2", ci));
            Outcometxt.Text = totalInterest.ToString("N2", ci); // 總利息支出
            Repaymenttxt.Text = totalRepayment.ToString("N2", ci); // 總還款金額
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            // 清除/重設所有輸入與輸出，恢復 Designer 的提示文字（使用 RegisterPlaceholder 所設定的提示）
            SetPlaceholderText(Totaltxt);
            SetPlaceholderText(textBox6);
            SetPlaceholderText(textBox7);
            SetPlaceholderText(Annualtxt);
            SetPlaceholderText(Loantxt);
            SetPlaceholderText(Gracetxt);

            TotalOuttxt.Text = "單位:新台幣(NTD)";
            MonthOuttxt.Text = "單位:新台幣(NTD)";
            FirstOuttxt.Text = "單位:新台幣(NTD)";
            Outcometxt.Text = "單位:新台幣(NTD)";
            Repaymenttxt.Text = "單位:新台幣(NTD)";

            Percentagecheck.Checked = true;
            UpdateDownPaymentInputs();
        }

        private void DownPaymentModeChanged(object sender, EventArgs e)
        {
            UpdateDownPaymentInputs();
        }

        private void UpdateDownPaymentInputs()
        {
            // 根據選擇啟用/停用對應輸入欄位
            bool useAmount = Pricecheck.Checked;

            textBox6.Enabled = useAmount;
            textBox6.BackColor = useAmount ? Color.White : Color.LightGray;
            if (!useAmount)
                SetPlaceholderText(textBox6);

            textBox7.Enabled = !useAmount;
            textBox7.BackColor = !useAmount ? Color.White : Color.LightGray;
            if (useAmount)
                SetPlaceholderText(textBox7);
        }

        #region Placeholder 實作
        private void RegisterPlaceholder(TextBox tb, string placeholder)
        {
            tb.Tag = placeholder;
            tb.Enter += TextBox_Enter;
            tb.Leave += TextBox_Leave;

            // 設定初始提示文字（如果目前沒有有意義的值）
            if (string.IsNullOrWhiteSpace(tb.Text) || IsPlaceholderText(tb.Text, placeholder))
            {
                tb.Text = placeholder;
                tb.ForeColor = PlaceholderColor;
            }
            else
            {
                // 若設計時已填預設提示文字，保持 Placeholder 色彩
                if (IsPlaceholderText(tb.Text, placeholder))
                    tb.ForeColor = PlaceholderColor;
                else
                    tb.ForeColor = ActiveColor;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var placeholder = tb.Tag as string;
            if (placeholder == null) return;

            if (IsPlaceholderText(tb.Text, placeholder))
            {
                tb.Text = string.Empty;
            }
            tb.ForeColor = ActiveColor;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var placeholder = tb.Tag as string;
            if (placeholder == null) return;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = placeholder;
                tb.ForeColor = PlaceholderColor;
            }
            else
            {
                tb.ForeColor = ActiveColor;
            }
        }

        private void SetPlaceholderText(TextBox tb)
        {
            var placeholder = tb.Tag as string;
            if (placeholder == null) return;
            tb.Text = placeholder;
            tb.ForeColor = PlaceholderColor;
        }

        private bool IsPlaceholderText(string text, string placeholder)
        {
            if (text == null) return false;
            return string.Equals(text.Trim(), placeholder, StringComparison.CurrentCulture);
        }

        // 下面改為遞迴搜尋所有子控制項，避免當某些 textbox 被放入 panel/groupbox 時找不到 placeholder 的情況
        private IEnumerable<Control> EnumerateAllControls(Control root)
        {
            if (root == null) yield break;
            yield return root;
            foreach (Control child in root.Controls)
            {
                foreach (var c in EnumerateAllControls(child))
                    yield return c;
            }
        }

        private bool IsPlaceholderOrEmpty(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return true;
            // 檢查所有已註冊輸入框的 placeholder（包含容器內）
            foreach (Control c in EnumerateAllControls(this))
            {
                var tb = c as TextBox;
                if (tb == null) continue;
                var ph = tb.Tag as string;
                if (ph == null) continue;
                if (string.Equals(text.Trim(), ph, StringComparison.CurrentCulture))
                    return true;
            }
            return false;
        }
        #endregion

        private bool TryParseDouble(string s, out double value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(s)) return false;

            // 若 s 為已註冊的 placeholder，視為空（用遞迴搜尋所有控制項）
            foreach (Control c in EnumerateAllControls(this))
            {
                var tb = c as TextBox;
                if (tb == null) continue;
                var ph = tb.Tag as string;
                if (ph == null) continue;
                if (string.Equals(s.Trim(), ph, StringComparison.CurrentCulture))
                    return false;
            }

            // 允許使用千分符號與小數點（依目前文化）
            if (double.TryParse(s, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out value))
                return true;

            if (double.TryParse(s, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out value))
                return true;

            return false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void s1131430_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)    
        {

        }

        // 建立自訂的 Enter 導覽順序（確保包含自備款金額/比例兩欄）
        private void BuildEnterNavigationOrder()
        {
            // 若你未更改控制項名稱，使用下列順序；如有變動請對應修改
            var list = new List<Control>
            {
                Totaltxt,   // 房屋總價
                textBox6,   // 自備款(金額)
                textBox7,   // 自備款(比例)
                Annualtxt,  // 年利率
                Loantxt,    // 貸款年限
                Gracetxt    // 寬限期
            };

            // 保留只存在的控制項（避免 null）
            enterOrder = list.Where(c => c != null).ToArray();
        }

        // 新增：為所有可輸入的單行 TextBox 加上按 Enter 跳下一格的行為
        private void AttachEnterKeyNavigation()
        {
            foreach (Control c in EnumerateAllControls(this))
            {
                var tb = c as TextBox;
                if (tb == null) continue;
                // 只對可輸入、非唯讀、非 Multiline 的 textbox 加上行為
                if (!tb.ReadOnly && tb.Enabled && !tb.Multiline)
                {
                    // 避免重複綁定
                    tb.KeyDown -= InputTextBox_KeyDown;
                    tb.KeyDown += InputTextBox_KeyDown;
                }
            }
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 防止系統發出提示音
                e.SuppressKeyPress = true;

                var ctl = sender as Control;
                if (ctl == null) return;

                // 嘗試使用自訂的順序（優先，確保不跳過自備款）
                if (enterOrder != null && enterOrder.Length > 0)
                {
                    int idx = Array.IndexOf(enterOrder, ctl);
                    if (idx >= 0)
                    {
                        for (int i = idx + 1; i < enterOrder.Length; i++)
                        {
                            var next = enterOrder[i];
                            if (next == null) continue;
                            if (!next.Visible) continue;
                            if (!next.Enabled) continue;
                            var tbNext = next as TextBox;
                            if (tbNext != null && tbNext.ReadOnly) continue;
                            next.Focus();
                            return;
                        }

                        // 若自訂順序已到尾，嘗試回到整體 Tab 順序的下一個控制項
                        this.SelectNextControl(ctl, true, true, true, true);
                        return;
                    }
                }

                // fallback：使用預設 SelectNextControl
                this.SelectNextControl(ctl, true, true, true, true);
            }
        }
    }
}
