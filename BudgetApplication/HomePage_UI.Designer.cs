
namespace BudgetApplication
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.pnlHomeSubmenue = new System.Windows.Forms.Panel();
            this.btnHomeLoan = new System.Windows.Forms.Button();
            this.btnRentHome = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txbDate = new System.Windows.Forms.Label();
            this.txbTime = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlMainDisplay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txbGrossMonthlyIncome = new System.Windows.Forms.TextBox();
            this.lblAvailableMoney = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProviderGrossMonthlyIncome = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlHomeSubmenue.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.pnlMainDisplay.SuspendLayout();
            this.panelIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrossMonthlyIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnVehicle);
            this.pnlSidebar.Controls.Add(this.pnlHomeSubmenue);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnGeneral);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(254, 731);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnVehicle
            // 
            this.btnVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(213)))));
            this.btnVehicle.Location = new System.Drawing.Point(0, 428);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVehicle.Size = new System.Drawing.Size(254, 59);
            this.btnVehicle.TabIndex = 10;
            this.btnVehicle.Text = "Vehicle Expense";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnVehicle, "Select if you want to buy a property");
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click_1);
            // 
            // pnlHomeSubmenue
            // 
            this.pnlHomeSubmenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHomeSubmenue.Controls.Add(this.btnHomeLoan);
            this.pnlHomeSubmenue.Controls.Add(this.btnRentHome);
            this.pnlHomeSubmenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeSubmenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHomeSubmenue.Location = new System.Drawing.Point(0, 308);
            this.pnlHomeSubmenue.Name = "pnlHomeSubmenue";
            this.pnlHomeSubmenue.Size = new System.Drawing.Size(254, 120);
            this.pnlHomeSubmenue.TabIndex = 6;
            // 
            // btnHomeLoan
            // 
            this.btnHomeLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(213)))));
            this.btnHomeLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHomeLoan.FlatAppearance.BorderSize = 0;
            this.btnHomeLoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHomeLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeLoan.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHomeLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.btnHomeLoan.Location = new System.Drawing.Point(0, 59);
            this.btnHomeLoan.Name = "btnHomeLoan";
            this.btnHomeLoan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHomeLoan.Size = new System.Drawing.Size(254, 61);
            this.btnHomeLoan.TabIndex = 4;
            this.btnHomeLoan.Text = "Loan";
            this.btnHomeLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnHomeLoan, "Select if you want to buy a property");
            this.btnHomeLoan.UseVisualStyleBackColor = false;
            this.btnHomeLoan.Click += new System.EventHandler(this.btnHomeLoan_Click);
            // 
            // btnRentHome
            // 
            this.btnRentHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(213)))));
            this.btnRentHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentHome.FlatAppearance.BorderSize = 0;
            this.btnRentHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRentHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRentHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.btnRentHome.Location = new System.Drawing.Point(0, 0);
            this.btnRentHome.Name = "btnRentHome";
            this.btnRentHome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRentHome.Size = new System.Drawing.Size(254, 59);
            this.btnRentHome.TabIndex = 5;
            this.btnRentHome.Text = "Rent";
            this.btnRentHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnRentHome, "Select if you want to rent a property");
            this.btnRentHome.UseVisualStyleBackColor = false;
            this.btnRentHome.Click += new System.EventHandler(this.btnRentHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(213)))));
            this.btnHome.Location = new System.Drawing.Point(0, 249);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(254, 59);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home Expense";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnHome, "Select to enter your home expenses provided with the respective options");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(213)))));
            this.btnGeneral.Location = new System.Drawing.Point(0, 190);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGeneral.Size = new System.Drawing.Size(254, 59);
            this.btnGeneral.TabIndex = 1;
            this.btnGeneral.Text = "General Expense";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnGeneral, "Select to enter your general expenses provided with the respective options");
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(213)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 190);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::BudgetApplication.Properties.Resources.logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 190);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "Click to display home page");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__9_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-168, 676);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(422, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnExit, "Click to close application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.txbDate);
            this.pnlHeader.Controls.Add(this.txbTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(254, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(954, 49);
            this.pnlHeader.TabIndex = 1;
            // 
            // txbDate
            // 
            this.txbDate.AutoSize = true;
            this.txbDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.txbDate.Location = new System.Drawing.Point(490, 21);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(42, 25);
            this.txbDate.TabIndex = 5;
            this.txbDate.Text = "DD";
            // 
            // txbTime
            // 
            this.txbTime.AutoSize = true;
            this.txbTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.txbTime.Location = new System.Drawing.Point(700, 21);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(30, 25);
            this.txbTime.TabIndex = 4;
            this.txbTime.Text = "TT";
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.pnlChildForm.Controls.Add(this.pnlMainDisplay);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(254, 49);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(954, 682);
            this.pnlChildForm.TabIndex = 2;
            // 
            // pnlMainDisplay
            // 
            this.pnlMainDisplay.Controls.Add(this.label2);
            this.pnlMainDisplay.Controls.Add(this.panelIncome);
            this.pnlMainDisplay.Controls.Add(this.lblAvailableMoney);
            this.pnlMainDisplay.Controls.Add(this.panel4);
            this.pnlMainDisplay.Controls.Add(this.panel3);
            this.pnlMainDisplay.Controls.Add(this.panel2);
            this.pnlMainDisplay.Controls.Add(this.label3);
            this.pnlMainDisplay.Controls.Add(this.label4);
            this.pnlMainDisplay.Location = new System.Drawing.Point(32, 43);
            this.pnlMainDisplay.Name = "pnlMainDisplay";
            this.pnlMainDisplay.Size = new System.Drawing.Size(891, 558);
            this.pnlMainDisplay.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(58, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "General Expense ";
            // 
            // panelIncome
            // 
            this.panelIncome.Controls.Add(this.label1);
            this.panelIncome.Controls.Add(this.btnNext);
            this.panelIncome.Controls.Add(this.txbGrossMonthlyIncome);
            this.panelIncome.Location = new System.Drawing.Point(46, 23);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(652, 75);
            this.panelIncome.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gross Monthly Income : R";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__2_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.errorProviderGrossMonthlyIncome.SetIconAlignment(this.btnNext, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(506, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 43);
            this.btnNext.TabIndex = 56;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnNext, "Clcik nect to calculate and proceed");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txbGrossMonthlyIncome
            // 
            this.txbGrossMonthlyIncome.BackColor = System.Drawing.SystemColors.Window;
            this.txbGrossMonthlyIncome.ForeColor = System.Drawing.Color.Black;
            this.txbGrossMonthlyIncome.Location = new System.Drawing.Point(325, 26);
            this.txbGrossMonthlyIncome.Name = "txbGrossMonthlyIncome";
            this.txbGrossMonthlyIncome.PlaceholderText = "Gross monthly Income";
            this.txbGrossMonthlyIncome.Size = new System.Drawing.Size(175, 26);
            this.txbGrossMonthlyIncome.TabIndex = 48;
            this.toolTip1.SetToolTip(this.txbGrossMonthlyIncome, "Enter your gross monthly income in the respective format of e.g. 100.00");
            // 
            // lblAvailableMoney
            // 
            this.lblAvailableMoney.AutoSize = true;
            this.lblAvailableMoney.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableMoney.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAvailableMoney.Location = new System.Drawing.Point(46, 491);
            this.lblAvailableMoney.Name = "lblAvailableMoney";
            this.lblAvailableMoney.Size = new System.Drawing.Size(0, 28);
            this.lblAvailableMoney.TabIndex = 59;
            this.toolTip1.SetToolTip(this.lblAvailableMoney, "Your available money after deductions");
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__3_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(668, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 179);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__8_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(355, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 179);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BudgetApplication.Properties.Resources.output_onlinepngtools__7_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(46, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 179);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(370, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Home Expense ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(682, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vehicle Expense ";
            // 
            // errorProviderGrossMonthlyIncome
            // 
            this.errorProviderGrossMonthlyIncome.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 731);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmMain";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHomeSubmenue.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlMainDisplay.ResumeLayout(false);
            this.pnlMainDisplay.PerformLayout();
            this.panelIncome.ResumeLayout(false);
            this.panelIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrossMonthlyIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnHomeLoan;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel pnlHomeSubmenue;
        private System.Windows.Forms.Button btnRentHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderGrossMonthlyIncome;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txbGrossMonthlyIncome;
        public System.Windows.Forms.Panel pnlMainDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label txbTime;
        public System.Windows.Forms.Label lblAvailableMoney;
        private System.Windows.Forms.Label txbDate;
        private System.Windows.Forms.Label label2;
    }
}

