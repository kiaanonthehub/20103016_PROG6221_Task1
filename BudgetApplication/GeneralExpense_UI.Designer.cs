
namespace BudgetApplication
{
    partial class frmGeneral
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
            this.txbMonthlyTaxDeduction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTravelCost = new System.Windows.Forms.TextBox();
            this.txbGroceries = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbOtherExpense = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbWaterLights = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProviderTax = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGroceries = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWater = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTravel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOther = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGroceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTravel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOther)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMonthlyTaxDeduction
            // 
            this.txbMonthlyTaxDeduction.BackColor = System.Drawing.SystemColors.Window;
            this.txbMonthlyTaxDeduction.ForeColor = System.Drawing.Color.Black;
            this.txbMonthlyTaxDeduction.Location = new System.Drawing.Point(566, 142);
            this.txbMonthlyTaxDeduction.Name = "txbMonthlyTaxDeduction";
            this.txbMonthlyTaxDeduction.PlaceholderText = "Tax deductions";
            this.txbMonthlyTaxDeduction.Size = new System.Drawing.Size(175, 26);
            this.txbMonthlyTaxDeduction.TabIndex = 46;
            this.toolTip1.SetToolTip(this.txbMonthlyTaxDeduction, "Enter your estimated tax deduction in the respective format of 100.00");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Estimated Monthly Tax Deducted : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(541, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 19);
            this.label14.TabIndex = 47;
            this.label14.Text = "R";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(232, 407);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(178, 25);
            this.label31.TabIndex = 44;
            this.label31.Text = "Estimated amount : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(235, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Estimated Monthly Expenitures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Groceries :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(541, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 19);
            this.label10.TabIndex = 38;
            this.label10.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Water and Lights :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(541, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(234, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Travel Costs (Incl. Petrol) :";
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txbPhone.ForeColor = System.Drawing.Color.Black;
            this.txbPhone.Location = new System.Drawing.Point(566, 310);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.PlaceholderText = "Communication costs";
            this.txbPhone.Size = new System.Drawing.Size(175, 26);
            this.txbPhone.TabIndex = 37;
            this.toolTip1.SetToolTip(this.txbPhone, "Enter your communication expense in the respective format of 100.00\r\n\r\n");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(234, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cellphone and Telephone : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(541, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 19);
            this.label12.TabIndex = 40;
            this.label12.Text = "R";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(541, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "R";
            // 
            // txbTravelCost
            // 
            this.txbTravelCost.BackColor = System.Drawing.SystemColors.Window;
            this.txbTravelCost.ForeColor = System.Drawing.Color.Black;
            this.txbTravelCost.Location = new System.Drawing.Point(566, 265);
            this.txbTravelCost.Name = "txbTravelCost";
            this.txbTravelCost.PlaceholderText = "Transportation costs";
            this.txbTravelCost.Size = new System.Drawing.Size(175, 26);
            this.txbTravelCost.TabIndex = 36;
            this.toolTip1.SetToolTip(this.txbTravelCost, "Enter your transportationcosts including pertrol in the respective format of 100." +
        "00\r\n\r\n");
            // 
            // txbGroceries
            // 
            this.txbGroceries.BackColor = System.Drawing.SystemColors.Window;
            this.txbGroceries.ForeColor = System.Drawing.Color.Black;
            this.txbGroceries.Location = new System.Drawing.Point(566, 184);
            this.txbGroceries.Name = "txbGroceries";
            this.txbGroceries.PlaceholderText = "Groceries costs";
            this.txbGroceries.Size = new System.Drawing.Size(175, 26);
            this.txbGroceries.TabIndex = 34;
            this.toolTip1.SetToolTip(this.txbGroceries, "Enter your grocery expense in the respective format of 100.00");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(541, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 19);
            this.label13.TabIndex = 41;
            this.label13.Text = "R";
            // 
            // txbOtherExpense
            // 
            this.txbOtherExpense.BackColor = System.Drawing.SystemColors.Window;
            this.txbOtherExpense.ForeColor = System.Drawing.Color.Black;
            this.txbOtherExpense.Location = new System.Drawing.Point(566, 405);
            this.txbOtherExpense.Name = "txbOtherExpense";
            this.txbOtherExpense.PlaceholderText = "Other costs";
            this.txbOtherExpense.Size = new System.Drawing.Size(175, 26);
            this.txbOtherExpense.TabIndex = 42;
            this.toolTip1.SetToolTip(this.txbOtherExpense, "Enter your other expense in the respective format of 100.00\r\nOr 0 if you dont hav" +
        "e any");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(234, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 32);
            this.label8.TabIndex = 33;
            this.label8.Tag = "";
            this.label8.Text = "Other Epenses";
            // 
            // txbWaterLights
            // 
            this.txbWaterLights.BackColor = System.Drawing.SystemColors.Window;
            this.txbWaterLights.ForeColor = System.Drawing.Color.Black;
            this.txbWaterLights.Location = new System.Drawing.Point(566, 225);
            this.txbWaterLights.Name = "txbWaterLights";
            this.txbWaterLights.PlaceholderText = "Water and Lights costs";
            this.txbWaterLights.Size = new System.Drawing.Size(175, 26);
            this.txbWaterLights.TabIndex = 35;
            this.toolTip1.SetToolTip(this.txbWaterLights, "Enter your water and light sbill expense in the respective format of 100.00\r\n");
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__2_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(785, 208);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 157);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnNext, "Click next to process and proceed");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__6_;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(53, 186);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 157);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnReset, "Click to reset fields");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // errorProviderTax
            // 
            this.errorProviderTax.ContainerControl = this;
            // 
            // errorProviderGroceries
            // 
            this.errorProviderGroceries.ContainerControl = this;
            // 
            // errorProviderWater
            // 
            this.errorProviderWater.ContainerControl = this;
            // 
            // errorProviderTravel
            // 
            this.errorProviderTravel.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderOther
            // 
            this.errorProviderOther.ContainerControl = this;
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.richTextBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDisplay.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDisplay.Location = new System.Drawing.Point(253, 498);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.ReadOnly = true;
            this.richTextBoxDisplay.Size = new System.Drawing.Size(506, 96);
            this.richTextBoxDisplay.TabIndex = 53;
            this.richTextBoxDisplay.Text = "";
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(954, 654);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txbMonthlyTaxDeduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbTravelCost);
            this.Controls.Add(this.txbGroceries);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbOtherExpense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbWaterLights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneral";
            this.Text = "General";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGroceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTravel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOther)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMonthlyTaxDeduction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTravelCost;
        private System.Windows.Forms.TextBox txbGroceries;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbOtherExpense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbWaterLights;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProviderTax;
        private System.Windows.Forms.ErrorProvider errorProviderGroceries;
        private System.Windows.Forms.ErrorProvider errorProviderWater;
        private System.Windows.Forms.ErrorProvider errorProviderTravel;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.ErrorProvider errorProviderOther;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}