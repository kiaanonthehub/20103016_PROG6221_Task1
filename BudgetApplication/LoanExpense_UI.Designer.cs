
namespace BudgetApplication
{
    partial class frmHomeLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.txbPurchasePriceProp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbInterestRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNoOfMonthsRepay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLoan = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.errorProviderPurchase = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeposit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInterest = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMonths = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(399, 81);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.PlaceholderText = "Deposit funds";
            this.txbDeposit.Size = new System.Drawing.Size(140, 26);
            this.txbDeposit.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txbDeposit, "Enter the desposited amount in the respective format of 100.00\r\n\r\n");
            // 
            // txbPurchasePriceProp
            // 
            this.txbPurchasePriceProp.Location = new System.Drawing.Point(399, 42);
            this.txbPurchasePriceProp.Name = "txbPurchasePriceProp";
            this.txbPurchasePriceProp.PlaceholderText = "Purchase costs";
            this.txbPurchasePriceProp.Size = new System.Drawing.Size(140, 26);
            this.txbPurchasePriceProp.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txbPurchasePriceProp, "Enter the purchase price in the respective format of 100.00");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(34, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(349, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Number of months to repay (240 - 360) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(374, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Interest rate (percentage) :";
            // 
            // txbInterestRate
            // 
            this.txbInterestRate.Location = new System.Drawing.Point(399, 121);
            this.txbInterestRate.Name = "txbInterestRate";
            this.txbInterestRate.PlaceholderText = "Intrest";
            this.txbInterestRate.Size = new System.Drawing.Size(51, 26);
            this.txbInterestRate.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txbInterestRate, "Enter  in the interest rate of respective decimal format of eg. 0.1\r\n\r\n");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total deposit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(374, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "R";
            // 
            // txbNoOfMonthsRepay
            // 
            this.txbNoOfMonthsRepay.Location = new System.Drawing.Point(399, 166);
            this.txbNoOfMonthsRepay.Name = "txbNoOfMonthsRepay";
            this.txbNoOfMonthsRepay.PlaceholderText = "Month";
            this.txbNoOfMonthsRepay.Size = new System.Drawing.Size(51, 26);
            this.txbNoOfMonthsRepay.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txbNoOfMonthsRepay, "Enter the number of monts between 240 and 360");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Purchase price of property :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "months";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Purchase details";
            // 
            // pnlLoan
            // 
            this.pnlLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.pnlLoan.Controls.Add(this.label1);
            this.pnlLoan.Controls.Add(this.label2);
            this.pnlLoan.Controls.Add(this.label3);
            this.pnlLoan.Controls.Add(this.label4);
            this.pnlLoan.Controls.Add(this.txbNoOfMonthsRepay);
            this.pnlLoan.Controls.Add(this.label5);
            this.pnlLoan.Controls.Add(this.label6);
            this.pnlLoan.Controls.Add(this.txbInterestRate);
            this.pnlLoan.Controls.Add(this.label7);
            this.pnlLoan.Controls.Add(this.label8);
            this.pnlLoan.Controls.Add(this.label9);
            this.pnlLoan.Controls.Add(this.txbPurchasePriceProp);
            this.pnlLoan.Controls.Add(this.txbDeposit);
            this.pnlLoan.ForeColor = System.Drawing.Color.White;
            this.pnlLoan.Location = new System.Drawing.Point(172, 145);
            this.pnlLoan.Name = "pnlLoan";
            this.pnlLoan.Size = new System.Drawing.Size(595, 205);
            this.pnlLoan.TabIndex = 54;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__6_;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(33, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 157);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnReset, "Click to reset fields");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__2_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(791, 166);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 157);
            this.btnNext.TabIndex = 55;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnNext, "Clcik to process and proceed");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProviderPurchase
            // 
            this.errorProviderPurchase.ContainerControl = this;
            // 
            // errorProviderDeposit
            // 
            this.errorProviderDeposit.ContainerControl = this;
            // 
            // errorProviderInterest
            // 
            this.errorProviderInterest.ContainerControl = this;
            // 
            // errorProviderMonths
            // 
            this.errorProviderMonths.ContainerControl = this;
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.richTextBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDisplay.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDisplay.Location = new System.Drawing.Point(172, 424);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.ReadOnly = true;
            this.richTextBoxDisplay.Size = new System.Drawing.Size(595, 96);
            this.richTextBoxDisplay.TabIndex = 57;
            this.richTextBoxDisplay.Text = "";
            // 
            // frmHomeLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(954, 682);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeLoan";
            this.Text = "HomeLoan";
            this.pnlLoan.ResumeLayout(false);
            this.pnlLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.TextBox txbPurchasePriceProp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbInterestRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNoOfMonthsRepay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlLoan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errorProviderPurchase;
        private System.Windows.Forms.ErrorProvider errorProviderDeposit;
        private System.Windows.Forms.ErrorProvider errorProviderInterest;
        private System.Windows.Forms.ErrorProvider errorProviderMonths;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}