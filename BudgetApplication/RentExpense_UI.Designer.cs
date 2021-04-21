
namespace BudgetApplication
{
    partial class frmHomeRent
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
            this.pnlRent = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.txbMonthlyRentalAmount = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.errorProviderRent = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRent
            // 
            this.pnlRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.pnlRent.Controls.Add(this.label34);
            this.pnlRent.Controls.Add(this.txbMonthlyRentalAmount);
            this.pnlRent.Controls.Add(this.label30);
            this.pnlRent.Controls.Add(this.label32);
            this.pnlRent.ForeColor = System.Drawing.Color.White;
            this.pnlRent.Location = new System.Drawing.Point(187, 210);
            this.pnlRent.Name = "pnlRent";
            this.pnlRent.Size = new System.Drawing.Size(579, 90);
            this.pnlRent.TabIndex = 57;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label34.ForeColor = System.Drawing.Color.LightGray;
            this.label34.Location = new System.Drawing.Point(9, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(148, 32);
            this.label34.TabIndex = 35;
            this.label34.Text = "Rent details";
            // 
            // txbMonthlyRentalAmount
            // 
            this.txbMonthlyRentalAmount.Location = new System.Drawing.Point(337, 48);
            this.txbMonthlyRentalAmount.Name = "txbMonthlyRentalAmount";
            this.txbMonthlyRentalAmount.PlaceholderText = "Rental costs";
            this.txbMonthlyRentalAmount.Size = new System.Drawing.Size(140, 26);
            this.txbMonthlyRentalAmount.TabIndex = 33;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(9, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(210, 25);
            this.label30.TabIndex = 0;
            this.label30.Text = "Monthly rental amount:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(312, 48);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 19);
            this.label32.TabIndex = 34;
            this.label32.Text = "R";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__6_;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(55, 171);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 157);
            this.btnReset.TabIndex = 59;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnNext.Location = new System.Drawing.Point(796, 193);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 157);
            this.btnNext.TabIndex = 58;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errorProviderRent
            // 
            this.errorProviderRent.ContainerControl = this;
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.richTextBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDisplay.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDisplay.Location = new System.Drawing.Point(187, 371);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(579, 51);
            this.richTextBoxDisplay.TabIndex = 60;
            this.richTextBoxDisplay.Text = "";
            // 
            // frmHomeRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(954, 682);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeRent";
            this.Text = "HomeRent";
            this.pnlRent.ResumeLayout(false);
            this.pnlRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlRent;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txbMonthlyRentalAmount;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProviderRent;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}