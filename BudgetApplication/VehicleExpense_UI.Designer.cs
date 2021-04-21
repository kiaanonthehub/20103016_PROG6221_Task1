
namespace BudgetApplication
{
    partial class frmVehicle
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLoan = new System.Windows.Forms.Panel();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbInsurance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIntrest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPurchasePrice = new System.Windows.Forms.TextBox();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProviderMake = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPurchasePrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeposit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInterest = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInsurance = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInsurance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__4_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(-1, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 57);
            this.btnBack.TabIndex = 52;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnlLoan
            // 
            this.pnlLoan.Controls.Add(this.cmbMake);
            this.pnlLoan.Controls.Add(this.label10);
            this.pnlLoan.Controls.Add(this.label12);
            this.pnlLoan.Controls.Add(this.txbModel);
            this.pnlLoan.Controls.Add(this.label1);
            this.pnlLoan.Controls.Add(this.label2);
            this.pnlLoan.Controls.Add(this.label3);
            this.pnlLoan.Controls.Add(this.label4);
            this.pnlLoan.Controls.Add(this.txbInsurance);
            this.pnlLoan.Controls.Add(this.label5);
            this.pnlLoan.Controls.Add(this.label6);
            this.pnlLoan.Controls.Add(this.txbIntrest);
            this.pnlLoan.Controls.Add(this.label7);
            this.pnlLoan.Controls.Add(this.label8);
            this.pnlLoan.Controls.Add(this.label9);
            this.pnlLoan.Controls.Add(this.txbPurchasePrice);
            this.pnlLoan.Controls.Add(this.txbDeposit);
            this.pnlLoan.ForeColor = System.Drawing.Color.White;
            this.pnlLoan.Location = new System.Drawing.Point(199, 155);
            this.pnlLoan.Name = "pnlLoan";
            this.pnlLoan.Size = new System.Drawing.Size(521, 309);
            this.pnlLoan.TabIndex = 56;
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Ferrari",
            "Ford",
            "GM",
            "GEM",
            "GMC",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Isuzu",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Lotus",
            "Mazda",
            "Mercedes-Benz",
            "Mercury",
            "Mitsubishi",
            "Nissan",
            "Oldsmobile",
            "Peugeot",
            "Pontiac",
            "Porsche",
            "Regal",
            "Saab",
            "Saturn",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cmbMake.Location = new System.Drawing.Point(327, 56);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(140, 27);
            this.cmbMake.TabIndex = 38;
            this.cmbMake.Text = "Makes";
            this.toolTip1.SetToolTip(this.cmbMake, "Select one make from the available list provided");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Make :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(9, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Model :";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(327, 98);
            this.txbModel.Name = "txbModel";
            this.txbModel.PlaceholderText = "Model";
            this.txbModel.Size = new System.Drawing.Size(140, 26);
            this.txbModel.TabIndex = 37;
            this.toolTip1.SetToolTip(this.txbModel, "Enter a Model of the vehicle make selected above");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Purchase details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Purchase price of vehicle :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "%";
            // 
            // txbInsurance
            // 
            this.txbInsurance.Location = new System.Drawing.Point(327, 265);
            this.txbInsurance.Name = "txbInsurance";
            this.txbInsurance.PlaceholderText = "Estimate";
            this.txbInsurance.Size = new System.Drawing.Size(67, 26);
            this.txbInsurance.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(302, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total deposit :";
            // 
            // txbIntrest
            // 
            this.txbIntrest.Location = new System.Drawing.Point(327, 220);
            this.txbIntrest.Name = "txbIntrest";
            this.txbIntrest.PlaceholderText = "Intrest";
            this.txbIntrest.Size = new System.Drawing.Size(67, 26);
            this.txbIntrest.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Interest rate (percentage) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(302, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "R";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Estimated insurace premium :";
            // 
            // txbPurchasePrice
            // 
            this.txbPurchasePrice.Location = new System.Drawing.Point(327, 141);
            this.txbPurchasePrice.Name = "txbPurchasePrice";
            this.txbPurchasePrice.PlaceholderText = "Purchase costs";
            this.txbPurchasePrice.Size = new System.Drawing.Size(140, 26);
            this.txbPurchasePrice.TabIndex = 25;
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(327, 180);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.PlaceholderText = "Deposit funds";
            this.txbDeposit.Size = new System.Drawing.Size(140, 26);
            this.txbDeposit.TabIndex = 24;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__6_;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(57, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 157);
            this.btnReset.TabIndex = 58;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__2_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(764, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 157);
            this.button2.TabIndex = 57;
            this.button2.Text = "Next";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProviderMake
            // 
            this.errorProviderMake.ContainerControl = this;
            // 
            // errorProviderModel
            // 
            this.errorProviderModel.ContainerControl = this;
            // 
            // errorProviderPurchasePrice
            // 
            this.errorProviderPurchasePrice.ContainerControl = this;
            // 
            // errorProviderDeposit
            // 
            this.errorProviderDeposit.ContainerControl = this;
            // 
            // errorProviderInterest
            // 
            this.errorProviderInterest.ContainerControl = this;
            // 
            // errorProviderInsurance
            // 
            this.errorProviderInsurance.ContainerControl = this;
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.richTextBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDisplay.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDisplay.Location = new System.Drawing.Point(199, 516);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(521, 96);
            this.richTextBoxDisplay.TabIndex = 59;
            this.richTextBoxDisplay.Text = "";
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(954, 682);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlLoan);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVehicle";
            this.Text = "Vehicle";
            this.pnlLoan.ResumeLayout(false);
            this.pnlLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInsurance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Panel pnlLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbInsurance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIntrest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPurchasePrice;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProviderMake;
        private System.Windows.Forms.ErrorProvider errorProviderModel;
        private System.Windows.Forms.ErrorProvider errorProviderPurchasePrice;
        private System.Windows.Forms.ErrorProvider errorProviderDeposit;
        private System.Windows.Forms.ErrorProvider errorProviderInterest;
        private System.Windows.Forms.ErrorProvider errorProviderInsurance;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}