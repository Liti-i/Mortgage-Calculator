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
            this.btnReset.Click += Resetbtn_Click;
            this.lblMoney.CheckedChanged += DownPaymentModeChanged;
            this.lblPercentage.CheckedChanged += DownPaymentModeChanged;
            this.btnCal.Click += Calbtn_Click;

            // 註冊輸入框的 focus 事件以實作提示文字（placeholder）
            RegisterPlaceholder(txtTotal, "單位:新台幣(NTD)");
            RegisterPlaceholder(txtMoney, "單位:新台幣(NTD)");
            RegisterPlaceholder(txtPercentage, "百分比(%)");
            RegisterPlaceholder(txtAnnual, "百分比(%)");
            RegisterPlaceholder(txtLoan, "單位為年");
            RegisterPlaceholder(txtGrace, "單位為年");

            // 建立 Enter 跳格的順序並綁定事件
            BuildEnterNavigationOrder();
            AttachEnterKeyNavigation();

            // 初始為比例輸入預設
            this.lblPercentage.Checked = true;
            UpdateDownPaymentInputs();
        }

        private void Totallbl_Click(object sender, EventArgs e)
        {

        }

        private void Calbtn_Click(object sender, EventArgs e)
        {

            if (!TryParseDouble(txtTotal.Text, out double totalPrice) || totalPrice <= 0)
            {
                MessageBox.Show("請輸入有效的房屋總價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double downPayment = 0.0;
            if (lblMoney.Checked)
            {
                if (!TryParseDouble(txtMoney.Text, out downPayment) || downPayment < 0)
                {
                    MessageBox.Show("請輸入有效的自備款金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (!TryParseDouble(txtPercentage.Text, out double downPercent) || downPercent < 0)
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

            if (!TryParseDouble(txtAnnual.Text, out double annualRate) || annualRate < 0)
            {
                MessageBox.Show("請輸入有效的年利率(%)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryParseDouble(txtLoan.Text, out double loanYearsDouble) || loanYearsDouble <= 0)
            {
                MessageBox.Show("請輸入有效的貸款年限(年)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int loanYears = (int)Math.Round(loanYearsDouble);
            int totalMonths = loanYears * 12;

            int graceYears = 0;
            if (!IsPlaceholderOrEmpty(txtGrace.Text))
            {
                if (!int.TryParse(txtGrace.Text, out graceYears) || graceYears < 0)
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
                if (Math.Abs(monthlyRate) < 1e-12)
                {
                    monthlyPayment = loanAmount / amortMonths;
                }
                else
                {
                    double pow = Math.Pow(1 + monthlyRate, amortMonths);
                    monthlyPayment = loanAmount * monthlyRate * pow / (pow - 1);
                }

                double remainingPrincipal = loanAmount;
                for (int m = 1; m <= amortMonths; m++)
                {
                    double interestPayment = remainingPrincipal * monthlyRate;
                    double principalPayment = monthlyPayment - interestPayment;

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

            var ci = CultureInfo.CurrentCulture;
            txtTotalOut.Text = loanAmount.ToString("N2", ci); 
            txtMonthOut.Text = monthlyPayment.ToString("N2", ci);
            txtFirstOut.Text = string.Format(ci, "利息: {0}  本金: {1}", firstPaymentInterest.ToString("N2", ci), firstPaymentPrincipal.ToString("N2", ci));
            txtOutcome.Text = totalInterest.ToString("N2", ci);
            txtRepayment.Text = totalRepayment.ToString("N2", ci); 
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            SetPlaceholderText(txtTotal);
            SetPlaceholderText(txtMoney);
            SetPlaceholderText(txtPercentage);
            SetPlaceholderText(txtAnnual);
            SetPlaceholderText(txtLoan);
            SetPlaceholderText(txtGrace);

            txtTotalOut.Text = "單位:新台幣(NTD)";
            txtMonthOut.Text = "單位:新台幣(NTD)";
            txtFirstOut.Text = "單位:新台幣(NTD)";
            txtOutcome.Text = "單位:新台幣(NTD)";
            txtRepayment.Text = "單位:新台幣(NTD)";

            lblPercentage.Checked = true;
            UpdateDownPaymentInputs();
        }

        private void DownPaymentModeChanged(object sender, EventArgs e)
        {
            UpdateDownPaymentInputs();
        }

        private void UpdateDownPaymentInputs()
        {
            bool useAmount = lblMoney.Checked;

            txtMoney.Enabled = useAmount;
            txtMoney.BackColor = useAmount ? Color.White : Color.LightGray;
            if (!useAmount)
                SetPlaceholderText(txtMoney);

            txtPercentage.Enabled = !useAmount;
            txtPercentage.BackColor = !useAmount ? Color.White : Color.LightGray;
            if (useAmount)
                SetPlaceholderText(txtPercentage);
        }

        private void RegisterPlaceholder(TextBox tb, string placeholder)
        {
            tb.Tag = placeholder;
            tb.Enter += TextBox_Enter;
            tb.Leave += TextBox_Leave;
            
            if (string.IsNullOrWhiteSpace(tb.Text) || IsPlaceholderText(tb.Text, placeholder))
            {
                tb.Text = placeholder;
                tb.ForeColor = PlaceholderColor;
            }
            else
            {
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

        private bool TryParseDouble(string s, out double value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(s)) return false;
            foreach (Control c in EnumerateAllControls(this))
            {
                var tb = c as TextBox;
                if (tb == null) continue;
                var ph = tb.Tag as string;
                if (ph == null) continue;
                if (string.Equals(s.Trim(), ph, StringComparison.CurrentCulture))
                    return false;
            }

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
                txtTotal,   // 房屋總價
                txtMoney,   // 自備款(金額)
                txtPercentage,   // 自備款(比例)
                txtAnnual,  // 年利率
                txtLoan,    // 貸款年限
                txtGrace    // 寬限期
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

        private void TotalOuttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
