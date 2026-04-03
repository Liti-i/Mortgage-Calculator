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
            this.pageInput = new System.Windows.Forms.TabPage();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtAnnual = new System.Windows.Forms.TextBox();
            this.txtGrace = new System.Windows.Forms.TextBox();
            this.lblGrace = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.RadioButton();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.Prepare = new System.Windows.Forms.GroupBox();
            this.pageOutput = new System.Windows.Forms.TabPage();
            this.lblRepayment = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtRepayment = new System.Windows.Forms.TextBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.lblFirstOut = new System.Windows.Forms.Label();
            this.txtFirstOut = new System.Windows.Forms.TextBox();
            this.lblMonthOut = new System.Windows.Forms.Label();
            this.txtMonthOut = new System.Windows.Forms.TextBox();
            this.txtTotalOut = new System.Windows.Forms.TextBox();
            this.lblTotalOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.page.SuspendLayout();
            this.pageInput.SuspendLayout();
            this.pageOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // page
            // 
            this.page.Controls.Add(this.pageInput);
            this.page.Controls.Add(this.pageOutput);
            this.page.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.page.Location = new System.Drawing.Point(25, 92);
            this.page.Name = "page";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(928, 587);
            this.page.TabIndex = 33;
            // 
            // pageInput
            // 
            this.pageInput.BackColor = System.Drawing.Color.SteelBlue;
            this.pageInput.Controls.Add(this.txtLoan);
            this.pageInput.Controls.Add(this.txtPercentage);
            this.pageInput.Controls.Add(this.txtAnnual);
            this.pageInput.Controls.Add(this.txtGrace);
            this.pageInput.Controls.Add(this.lblGrace);
            this.pageInput.Controls.Add(this.txtMoney);
            this.pageInput.Controls.Add(this.btnCal);
            this.pageInput.Controls.Add(this.txtTotal);
            this.pageInput.Controls.Add(this.lblPercentage);
            this.pageInput.Controls.Add(this.lblTotal);
            this.pageInput.Controls.Add(this.lblLoan);
            this.pageInput.Controls.Add(this.lblMoney);
            this.pageInput.Controls.Add(this.lblAnnual);
            this.pageInput.Controls.Add(this.Prepare);
            this.pageInput.Location = new System.Drawing.Point(4, 51);
            this.pageInput.Name = "pageInput";
            this.pageInput.Padding = new System.Windows.Forms.Padding(3);
            this.pageInput.Size = new System.Drawing.Size(920, 532);
            this.pageInput.TabIndex = 0;
            this.pageInput.Text = "輸入貸款資訊";
            this.pageInput.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLoan.Location = new System.Drawing.Point(219, 373);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(272, 47);
            this.txtLoan.TabIndex = 36;
            this.txtLoan.Text = "單位為年";
            this.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPercentage.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPercentage.Location = new System.Drawing.Point(219, 214);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(272, 47);
            this.txtPercentage.TabIndex = 41;
            this.txtPercentage.Text = "百分比(%)";
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnnual
            // 
            this.txtAnnual.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnnual.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAnnual.Location = new System.Drawing.Point(219, 307);
            this.txtAnnual.Name = "txtAnnual";
            this.txtAnnual.Size = new System.Drawing.Size(272, 47);
            this.txtAnnual.TabIndex = 35;
            this.txtAnnual.Tag = "";
            this.txtAnnual.Text = "百分比(%)";
            this.txtAnnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrace
            // 
            this.txtGrace.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGrace.ForeColor = System.Drawing.Color.DarkGray;
            this.txtGrace.Location = new System.Drawing.Point(273, 436);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(218, 47);
            this.txtGrace.TabIndex = 37;
            this.txtGrace.Text = "單位為年";
            this.txtGrace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrace
            // 
            this.lblGrace.AutoSize = true;
            this.lblGrace.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGrace.ForeColor = System.Drawing.Color.Black;
            this.lblGrace.Location = new System.Drawing.Point(42, 436);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(215, 42);
            this.lblGrace.TabIndex = 31;
            this.lblGrace.Text = "寬限期(選填):";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMoney.Location = new System.Drawing.Point(160, 159);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(331, 47);
            this.txtMoney.TabIndex = 40;
            this.txtMoney.Text = "單位:新台幣(NTD)";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCal.Location = new System.Drawing.Point(650, 334);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(248, 174);
            this.btnCal.TabIndex = 28;
            this.btnCal.Text = "計算按鈕";
            this.btnCal.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTotal.Location = new System.Drawing.Point(219, 44);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(272, 47);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.Text = "單位:新台幣(NTD)";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblPercentage.Location = new System.Drawing.Point(49, 212);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(167, 46);
            this.lblPercentage.TabIndex = 39;
            this.lblPercentage.TabStop = true;
            this.lblPercentage.Text = "比例(%):";
            this.lblPercentage.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(42, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 42);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "房屋總價:";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoan.ForeColor = System.Drawing.Color.Black;
            this.lblLoan.Location = new System.Drawing.Point(42, 373);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(158, 42);
            this.lblLoan.TabIndex = 32;
            this.lblLoan.Text = "貸款年限:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(49, 160);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(113, 46);
            this.lblMoney.TabIndex = 33;
            this.lblMoney.TabStop = true;
            this.lblMoney.Text = "金額:";
            this.lblMoney.UseVisualStyleBackColor = true;
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAnnual.ForeColor = System.Drawing.Color.Black;
            this.lblAnnual.Location = new System.Drawing.Point(42, 307);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(158, 42);
            this.lblAnnual.TabIndex = 30;
            this.lblAnnual.Text = "貸款利率:";
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
            // pageOutput
            // 
            this.pageOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.pageOutput.Controls.Add(this.lblRepayment);
            this.pageOutput.Controls.Add(this.btnReset);
            this.pageOutput.Controls.Add(this.txtRepayment);
            this.pageOutput.Controls.Add(this.lblOutcome);
            this.pageOutput.Controls.Add(this.txtOutcome);
            this.pageOutput.Controls.Add(this.lblFirstOut);
            this.pageOutput.Controls.Add(this.txtFirstOut);
            this.pageOutput.Controls.Add(this.lblMonthOut);
            this.pageOutput.Controls.Add(this.txtMonthOut);
            this.pageOutput.Controls.Add(this.txtTotalOut);
            this.pageOutput.Controls.Add(this.lblTotalOut);
            this.pageOutput.ForeColor = System.Drawing.Color.Transparent;
            this.pageOutput.Location = new System.Drawing.Point(4, 51);
            this.pageOutput.Name = "pageOutput";
            this.pageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.pageOutput.Size = new System.Drawing.Size(920, 532);
            this.pageOutput.TabIndex = 1;
            this.pageOutput.Text = "試算結果";
            // 
            // lblRepayment
            // 
            this.lblRepayment.AutoSize = true;
            this.lblRepayment.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRepayment.ForeColor = System.Drawing.Color.Black;
            this.lblRepayment.Location = new System.Drawing.Point(38, 353);
            this.lblRepayment.Name = "lblRepayment";
            this.lblRepayment.Size = new System.Drawing.Size(191, 42);
            this.lblRepayment.TabIndex = 26;
            this.lblRepayment.Text = "總還款金額:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(644, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(252, 180);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "重置/清除";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // txtRepayment
            // 
            this.txtRepayment.BackColor = System.Drawing.Color.SteelBlue;
            this.txtRepayment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRepayment.ForeColor = System.Drawing.Color.White;
            this.txtRepayment.Location = new System.Drawing.Point(262, 353);
            this.txtRepayment.Name = "txtRepayment";
            this.txtRepayment.ReadOnly = true;
            this.txtRepayment.Size = new System.Drawing.Size(314, 47);
            this.txtRepayment.TabIndex = 31;
            this.txtRepayment.Text = "單位:新台幣(NTD)";
            this.txtRepayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOutcome.ForeColor = System.Drawing.Color.Black;
            this.lblOutcome.Location = new System.Drawing.Point(38, 301);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(191, 42);
            this.lblOutcome.TabIndex = 27;
            this.lblOutcome.Text = "總利息支出:";
            // 
            // txtOutcome
            // 
            this.txtOutcome.BackColor = System.Drawing.Color.SteelBlue;
            this.txtOutcome.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutcome.ForeColor = System.Drawing.Color.White;
            this.txtOutcome.Location = new System.Drawing.Point(262, 301);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.ReadOnly = true;
            this.txtOutcome.Size = new System.Drawing.Size(314, 47);
            this.txtOutcome.TabIndex = 30;
            this.txtOutcome.Text = "單位:新台幣(NTD)";
            this.txtOutcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstOut
            // 
            this.lblFirstOut.AutoSize = true;
            this.lblFirstOut.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstOut.ForeColor = System.Drawing.Color.Black;
            this.lblFirstOut.Location = new System.Drawing.Point(38, 166);
            this.lblFirstOut.Name = "lblFirstOut";
            this.lblFirstOut.Size = new System.Drawing.Size(339, 42);
            this.lblFirstOut.TabIndex = 25;
            this.lblFirstOut.Text = "首期利息 與 首期本金:";
            // 
            // txtFirstOut
            // 
            this.txtFirstOut.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFirstOut.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstOut.ForeColor = System.Drawing.Color.White;
            this.txtFirstOut.Location = new System.Drawing.Point(421, 166);
            this.txtFirstOut.Multiline = true;
            this.txtFirstOut.Name = "txtFirstOut";
            this.txtFirstOut.ReadOnly = true;
            this.txtFirstOut.Size = new System.Drawing.Size(292, 114);
            this.txtFirstOut.TabIndex = 29;
            this.txtFirstOut.Tag = "";
            this.txtFirstOut.Text = "單位:新台幣(NTD)";
            this.txtFirstOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMonthOut
            // 
            this.lblMonthOut.AutoSize = true;
            this.lblMonthOut.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthOut.ForeColor = System.Drawing.Color.Black;
            this.lblMonthOut.Location = new System.Drawing.Point(38, 116);
            this.lblMonthOut.Name = "lblMonthOut";
            this.lblMonthOut.Size = new System.Drawing.Size(339, 42);
            this.lblMonthOut.TabIndex = 33;
            this.lblMonthOut.Text = "每月應繳金額(本+息):";
            // 
            // txtMonthOut
            // 
            this.txtMonthOut.BackColor = System.Drawing.Color.SteelBlue;
            this.txtMonthOut.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMonthOut.ForeColor = System.Drawing.Color.White;
            this.txtMonthOut.Location = new System.Drawing.Point(421, 116);
            this.txtMonthOut.Name = "txtMonthOut";
            this.txtMonthOut.ReadOnly = true;
            this.txtMonthOut.Size = new System.Drawing.Size(292, 47);
            this.txtMonthOut.TabIndex = 32;
            this.txtMonthOut.Text = "單位:新台幣(NTD)";
            this.txtMonthOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalOut
            // 
            this.txtTotalOut.BackColor = System.Drawing.Color.SteelBlue;
            this.txtTotalOut.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalOut.ForeColor = System.Drawing.Color.White;
            this.txtTotalOut.Location = new System.Drawing.Point(262, 55);
            this.txtTotalOut.Name = "txtTotalOut";
            this.txtTotalOut.ReadOnly = true;
            this.txtTotalOut.Size = new System.Drawing.Size(314, 47);
            this.txtTotalOut.TabIndex = 28;
            this.txtTotalOut.Text = "單位:新台幣(NTD)";
            this.txtTotalOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalOut.TextChanged += new System.EventHandler(this.TotalOuttxt_TextChanged);
            // 
            // lblTotalOut
            // 
            this.lblTotalOut.AutoSize = true;
            this.lblTotalOut.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalOut.ForeColor = System.Drawing.Color.Black;
            this.lblTotalOut.Location = new System.Drawing.Point(38, 60);
            this.lblTotalOut.Name = "lblTotalOut";
            this.lblTotalOut.Size = new System.Drawing.Size(191, 42);
            this.lblTotalOut.TabIndex = 24;
            this.lblTotalOut.Text = "貸款總金額:";
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
            this.pageInput.ResumeLayout(false);
            this.pageInput.PerformLayout();
            this.pageOutput.ResumeLayout(false);
            this.pageOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl page;
        private System.Windows.Forms.TabPage pageInput;
        private System.Windows.Forms.TabPage pageOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtAnnual;
        private System.Windows.Forms.TextBox txtGrace;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton lblPercentage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.RadioButton lblMoney;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.Label lblRepayment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtRepayment;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.Label lblFirstOut;
        private System.Windows.Forms.TextBox txtFirstOut;
        private System.Windows.Forms.Label lblMonthOut;
        private System.Windows.Forms.TextBox txtMonthOut;
        private System.Windows.Forms.TextBox txtTotalOut;
        private System.Windows.Forms.Label lblTotalOut;
        private System.Windows.Forms.GroupBox Prepare;
    }
}

