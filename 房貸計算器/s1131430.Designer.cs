namespace 房貸計算器
{
    partial class s1131430
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.page = new System.Windows.Forms.TabControl();
            this.Inputpage = new System.Windows.Forms.TabPage();
            this.Outputpage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Loantxt = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Annualtxt = new System.Windows.Forms.TextBox();
            this.Gracetxt = new System.Windows.Forms.TextBox();
            this.Gracelbl = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Calbtn = new System.Windows.Forms.Button();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.Percentagecheck = new System.Windows.Forms.RadioButton();
            this.Totallbl = new System.Windows.Forms.Label();
            this.Loanlbl = new System.Windows.Forms.Label();
            this.Pricecheck = new System.Windows.Forms.RadioButton();
            this.Annuallbl = new System.Windows.Forms.Label();
            this.Repaymentlbl = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Repaymenttxt = new System.Windows.Forms.TextBox();
            this.Outcometlbl = new System.Windows.Forms.Label();
            this.Outcometxt = new System.Windows.Forms.TextBox();
            this.FirstOutlbl = new System.Windows.Forms.Label();
            this.FirstOuttxt = new System.Windows.Forms.TextBox();
            this.MonthOutlbl = new System.Windows.Forms.Label();
            this.MonthOuttxt = new System.Windows.Forms.TextBox();
            this.TotalOuttxt = new System.Windows.Forms.TextBox();
            this.TotalOutlbl = new System.Windows.Forms.Label();
            this.Prepare = new System.Windows.Forms.GroupBox();
            this.page.SuspendLayout();
            this.Inputpage.SuspendLayout();
            this.Outputpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // page
            // 
            this.page.Controls.Add(this.Inputpage);
            this.page.Controls.Add(this.Outputpage);
            this.page.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.page.Location = new System.Drawing.Point(25, 92);
            this.page.Name = "page";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(928, 587);
            this.page.TabIndex = 33;
            // 
            // Inputpage
            // 
            this.Inputpage.BackColor = System.Drawing.Color.SteelBlue;
            this.Inputpage.Controls.Add(this.Loantxt);
            this.Inputpage.Controls.Add(this.textBox7);
            this.Inputpage.Controls.Add(this.Annualtxt);
            this.Inputpage.Controls.Add(this.Gracetxt);
            this.Inputpage.Controls.Add(this.Gracelbl);
            this.Inputpage.Controls.Add(this.textBox6);
            this.Inputpage.Controls.Add(this.Calbtn);
            this.Inputpage.Controls.Add(this.Totaltxt);
            this.Inputpage.Controls.Add(this.Percentagecheck);
            this.Inputpage.Controls.Add(this.Totallbl);
            this.Inputpage.Controls.Add(this.Loanlbl);
            this.Inputpage.Controls.Add(this.Pricecheck);
            this.Inputpage.Controls.Add(this.Annuallbl);
            this.Inputpage.Controls.Add(this.Prepare);
            this.Inputpage.Location = new System.Drawing.Point(4, 51);
            this.Inputpage.Name = "Inputpage";
            this.Inputpage.Padding = new System.Windows.Forms.Padding(3);
            this.Inputpage.Size = new System.Drawing.Size(920, 532);
            this.Inputpage.TabIndex = 0;
            this.Inputpage.Text = "輸入貸款資訊";
            this.Inputpage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Outputpage
            // 
            this.Outputpage.BackColor = System.Drawing.Color.SteelBlue;
            this.Outputpage.Controls.Add(this.Repaymentlbl);
            this.Outputpage.Controls.Add(this.Resetbtn);
            this.Outputpage.Controls.Add(this.Repaymenttxt);
            this.Outputpage.Controls.Add(this.Outcometlbl);
            this.Outputpage.Controls.Add(this.Outcometxt);
            this.Outputpage.Controls.Add(this.FirstOutlbl);
            this.Outputpage.Controls.Add(this.FirstOuttxt);
            this.Outputpage.Controls.Add(this.MonthOutlbl);
            this.Outputpage.Controls.Add(this.MonthOuttxt);
            this.Outputpage.Controls.Add(this.TotalOuttxt);
            this.Outputpage.Controls.Add(this.TotalOutlbl);
            this.Outputpage.ForeColor = System.Drawing.Color.Transparent;
            this.Outputpage.Location = new System.Drawing.Point(4, 51);
            this.Outputpage.Name = "Outputpage";
            this.Outputpage.Padding = new System.Windows.Forms.Padding(3);
            this.Outputpage.Size = new System.Drawing.Size(920, 532);
            this.Outputpage.TabIndex = 1;
            this.Outputpage.Text = "試算結果";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(625, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 66);
            this.label2.TabIndex = 35;
            this.label2.Text = "個人房貸試算器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loantxt
            // 
            this.Loantxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Loantxt.ForeColor = System.Drawing.Color.DarkGray;
            this.Loantxt.Location = new System.Drawing.Point(219, 373);
            this.Loantxt.Name = "Loantxt";
            this.Loantxt.Size = new System.Drawing.Size(272, 47);
            this.Loantxt.TabIndex = 36;
            this.Loantxt.Text = "單位為年";
            this.Loantxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox7.Location = new System.Drawing.Point(219, 214);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(272, 47);
            this.textBox7.TabIndex = 41;
            this.textBox7.Text = "百分比(%)";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Annualtxt
            // 
            this.Annualtxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Annualtxt.ForeColor = System.Drawing.Color.DarkGray;
            this.Annualtxt.Location = new System.Drawing.Point(219, 307);
            this.Annualtxt.Name = "Annualtxt";
            this.Annualtxt.Size = new System.Drawing.Size(272, 47);
            this.Annualtxt.TabIndex = 35;
            this.Annualtxt.Tag = "";
            this.Annualtxt.Text = "百分比(%)";
            this.Annualtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gracetxt
            // 
            this.Gracetxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gracetxt.ForeColor = System.Drawing.Color.DarkGray;
            this.Gracetxt.Location = new System.Drawing.Point(273, 436);
            this.Gracetxt.Name = "Gracetxt";
            this.Gracetxt.Size = new System.Drawing.Size(218, 47);
            this.Gracetxt.TabIndex = 37;
            this.Gracetxt.Text = "單位為年";
            this.Gracetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gracelbl
            // 
            this.Gracelbl.AutoSize = true;
            this.Gracelbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gracelbl.ForeColor = System.Drawing.Color.Black;
            this.Gracelbl.Location = new System.Drawing.Point(42, 436);
            this.Gracelbl.Name = "Gracelbl";
            this.Gracelbl.Size = new System.Drawing.Size(215, 42);
            this.Gracelbl.TabIndex = 31;
            this.Gracelbl.Text = "寬限期(選填):";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox6.Location = new System.Drawing.Point(160, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(331, 47);
            this.textBox6.TabIndex = 40;
            this.textBox6.Text = "單位:新台幣(NTD)";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calbtn
            // 
            this.Calbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Calbtn.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Calbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calbtn.Location = new System.Drawing.Point(650, 334);
            this.Calbtn.Name = "Calbtn";
            this.Calbtn.Size = new System.Drawing.Size(248, 174);
            this.Calbtn.TabIndex = 28;
            this.Calbtn.Text = "計算按鈕";
            this.Calbtn.UseVisualStyleBackColor = false;
            // 
            // Totaltxt
            // 
            this.Totaltxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Totaltxt.ForeColor = System.Drawing.Color.DarkGray;
            this.Totaltxt.Location = new System.Drawing.Point(219, 44);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.Size = new System.Drawing.Size(272, 47);
            this.Totaltxt.TabIndex = 34;
            this.Totaltxt.Text = "單位:新台幣(NTD)";
            this.Totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Percentagecheck
            // 
            this.Percentagecheck.AutoSize = true;
            this.Percentagecheck.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Percentagecheck.ForeColor = System.Drawing.Color.Black;
            this.Percentagecheck.Location = new System.Drawing.Point(49, 212);
            this.Percentagecheck.Name = "Percentagecheck";
            this.Percentagecheck.Size = new System.Drawing.Size(167, 46);
            this.Percentagecheck.TabIndex = 39;
            this.Percentagecheck.TabStop = true;
            this.Percentagecheck.Text = "比例(%):";
            this.Percentagecheck.UseVisualStyleBackColor = true;
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Totallbl.ForeColor = System.Drawing.Color.Black;
            this.Totallbl.Location = new System.Drawing.Point(42, 44);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(158, 42);
            this.Totallbl.TabIndex = 29;
            this.Totallbl.Text = "房屋總價:";
            // 
            // Loanlbl
            // 
            this.Loanlbl.AutoSize = true;
            this.Loanlbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Loanlbl.ForeColor = System.Drawing.Color.Black;
            this.Loanlbl.Location = new System.Drawing.Point(42, 373);
            this.Loanlbl.Name = "Loanlbl";
            this.Loanlbl.Size = new System.Drawing.Size(158, 42);
            this.Loanlbl.TabIndex = 32;
            this.Loanlbl.Text = "貸款年限:";
            // 
            // Pricecheck
            // 
            this.Pricecheck.AutoSize = true;
            this.Pricecheck.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pricecheck.ForeColor = System.Drawing.Color.Black;
            this.Pricecheck.Location = new System.Drawing.Point(49, 160);
            this.Pricecheck.Name = "Pricecheck";
            this.Pricecheck.Size = new System.Drawing.Size(113, 46);
            this.Pricecheck.TabIndex = 33;
            this.Pricecheck.TabStop = true;
            this.Pricecheck.Text = "金額:";
            this.Pricecheck.UseVisualStyleBackColor = true;
            // 
            // Annuallbl
            // 
            this.Annuallbl.AutoSize = true;
            this.Annuallbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Annuallbl.ForeColor = System.Drawing.Color.Black;
            this.Annuallbl.Location = new System.Drawing.Point(42, 307);
            this.Annuallbl.Name = "Annuallbl";
            this.Annuallbl.Size = new System.Drawing.Size(158, 42);
            this.Annuallbl.TabIndex = 30;
            this.Annuallbl.Text = "貸款利率:";
            // 
            // Repaymentlbl
            // 
            this.Repaymentlbl.AutoSize = true;
            this.Repaymentlbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Repaymentlbl.ForeColor = System.Drawing.Color.Black;
            this.Repaymentlbl.Location = new System.Drawing.Point(38, 353);
            this.Repaymentlbl.Name = "Repaymentlbl";
            this.Repaymentlbl.Size = new System.Drawing.Size(191, 42);
            this.Repaymentlbl.TabIndex = 26;
            this.Repaymentlbl.Text = "總還款金額:";
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.MistyRose;
            this.Resetbtn.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Resetbtn.ForeColor = System.Drawing.Color.Red;
            this.Resetbtn.Location = new System.Drawing.Point(644, 330);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(252, 180);
            this.Resetbtn.TabIndex = 34;
            this.Resetbtn.Text = "重置/清除";
            this.Resetbtn.UseVisualStyleBackColor = false;
            // 
            // Repaymenttxt
            // 
            this.Repaymenttxt.BackColor = System.Drawing.Color.SteelBlue;
            this.Repaymenttxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Repaymenttxt.ForeColor = System.Drawing.Color.White;
            this.Repaymenttxt.Location = new System.Drawing.Point(262, 353);
            this.Repaymenttxt.Name = "Repaymenttxt";
            this.Repaymenttxt.ReadOnly = true;
            this.Repaymenttxt.Size = new System.Drawing.Size(314, 47);
            this.Repaymenttxt.TabIndex = 31;
            this.Repaymenttxt.Text = "單位:新台幣(NTD)";
            this.Repaymenttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Outcometlbl
            // 
            this.Outcometlbl.AutoSize = true;
            this.Outcometlbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Outcometlbl.ForeColor = System.Drawing.Color.Black;
            this.Outcometlbl.Location = new System.Drawing.Point(38, 301);
            this.Outcometlbl.Name = "Outcometlbl";
            this.Outcometlbl.Size = new System.Drawing.Size(191, 42);
            this.Outcometlbl.TabIndex = 27;
            this.Outcometlbl.Text = "總利息支出:";
            // 
            // Outcometxt
            // 
            this.Outcometxt.BackColor = System.Drawing.Color.SteelBlue;
            this.Outcometxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Outcometxt.ForeColor = System.Drawing.Color.White;
            this.Outcometxt.Location = new System.Drawing.Point(262, 301);
            this.Outcometxt.Name = "Outcometxt";
            this.Outcometxt.ReadOnly = true;
            this.Outcometxt.Size = new System.Drawing.Size(314, 47);
            this.Outcometxt.TabIndex = 30;
            this.Outcometxt.Text = "單位:新台幣(NTD)";
            this.Outcometxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstOutlbl
            // 
            this.FirstOutlbl.AutoSize = true;
            this.FirstOutlbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstOutlbl.ForeColor = System.Drawing.Color.Black;
            this.FirstOutlbl.Location = new System.Drawing.Point(38, 166);
            this.FirstOutlbl.Name = "FirstOutlbl";
            this.FirstOutlbl.Size = new System.Drawing.Size(339, 42);
            this.FirstOutlbl.TabIndex = 25;
            this.FirstOutlbl.Text = "首期利息 與 首期本金:";
            // 
            // FirstOuttxt
            // 
            this.FirstOuttxt.BackColor = System.Drawing.Color.SteelBlue;
            this.FirstOuttxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstOuttxt.ForeColor = System.Drawing.Color.White;
            this.FirstOuttxt.Location = new System.Drawing.Point(421, 166);
            this.FirstOuttxt.Multiline = true;
            this.FirstOuttxt.Name = "FirstOuttxt";
            this.FirstOuttxt.ReadOnly = true;
            this.FirstOuttxt.Size = new System.Drawing.Size(292, 114);
            this.FirstOuttxt.TabIndex = 29;
            this.FirstOuttxt.Tag = "";
            this.FirstOuttxt.Text = "單位:新台幣(NTD)";
            this.FirstOuttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonthOutlbl
            // 
            this.MonthOutlbl.AutoSize = true;
            this.MonthOutlbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthOutlbl.ForeColor = System.Drawing.Color.Black;
            this.MonthOutlbl.Location = new System.Drawing.Point(38, 116);
            this.MonthOutlbl.Name = "MonthOutlbl";
            this.MonthOutlbl.Size = new System.Drawing.Size(339, 42);
            this.MonthOutlbl.TabIndex = 33;
            this.MonthOutlbl.Text = "每月應繳金額(本+息):";
            // 
            // MonthOuttxt
            // 
            this.MonthOuttxt.BackColor = System.Drawing.Color.SteelBlue;
            this.MonthOuttxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthOuttxt.ForeColor = System.Drawing.Color.White;
            this.MonthOuttxt.Location = new System.Drawing.Point(421, 116);
            this.MonthOuttxt.Name = "MonthOuttxt";
            this.MonthOuttxt.ReadOnly = true;
            this.MonthOuttxt.Size = new System.Drawing.Size(292, 47);
            this.MonthOuttxt.TabIndex = 32;
            this.MonthOuttxt.Text = "單位:新台幣(NTD)";
            this.MonthOuttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalOuttxt
            // 
            this.TotalOuttxt.BackColor = System.Drawing.Color.SteelBlue;
            this.TotalOuttxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalOuttxt.ForeColor = System.Drawing.Color.White;
            this.TotalOuttxt.Location = new System.Drawing.Point(262, 55);
            this.TotalOuttxt.Name = "TotalOuttxt";
            this.TotalOuttxt.ReadOnly = true;
            this.TotalOuttxt.Size = new System.Drawing.Size(314, 47);
            this.TotalOuttxt.TabIndex = 28;
            this.TotalOuttxt.Text = "單位:新台幣(NTD)";
            this.TotalOuttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalOutlbl
            // 
            this.TotalOutlbl.AutoSize = true;
            this.TotalOutlbl.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalOutlbl.ForeColor = System.Drawing.Color.Black;
            this.TotalOutlbl.Location = new System.Drawing.Point(38, 60);
            this.TotalOutlbl.Name = "TotalOutlbl";
            this.TotalOutlbl.Size = new System.Drawing.Size(191, 42);
            this.TotalOutlbl.TabIndex = 24;
            this.TotalOutlbl.Text = "貸款總金額:";
            // 
            // Prepare
            // 
            this.Prepare.Location = new System.Drawing.Point(34, 108);
            this.Prepare.Name = "Prepare";
            this.Prepare.Size = new System.Drawing.Size(493, 171);
            this.Prepare.TabIndex = 42;
            this.Prepare.TabStop = false;
            this.Prepare.Text = "自備款";
            this.Prepare.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // s1131430
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(983, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.page);
            this.Name = "s1131430";
            this.Text = "個人房貸試篹器";
            this.Load += new System.EventHandler(this.s1131430_Load);
            this.page.ResumeLayout(false);
            this.Inputpage.ResumeLayout(false);
            this.Inputpage.PerformLayout();
            this.Outputpage.ResumeLayout(false);
            this.Outputpage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl page;
        private System.Windows.Forms.TabPage Inputpage;
        private System.Windows.Forms.TabPage Outputpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Loantxt;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox Annualtxt;
        private System.Windows.Forms.TextBox Gracetxt;
        private System.Windows.Forms.Label Gracelbl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Calbtn;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.RadioButton Percentagecheck;
        private System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.Label Loanlbl;
        private System.Windows.Forms.RadioButton Pricecheck;
        private System.Windows.Forms.Label Annuallbl;
        private System.Windows.Forms.Label Repaymentlbl;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.TextBox Repaymenttxt;
        private System.Windows.Forms.Label Outcometlbl;
        private System.Windows.Forms.TextBox Outcometxt;
        private System.Windows.Forms.Label FirstOutlbl;
        private System.Windows.Forms.TextBox FirstOuttxt;
        private System.Windows.Forms.Label MonthOutlbl;
        private System.Windows.Forms.TextBox MonthOuttxt;
        private System.Windows.Forms.TextBox TotalOuttxt;
        private System.Windows.Forms.Label TotalOutlbl;
        private System.Windows.Forms.GroupBox Prepare;
    }
}

