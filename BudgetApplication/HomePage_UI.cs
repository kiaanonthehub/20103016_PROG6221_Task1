
// Author : Kiaan Maharaj

using BudgetAppLibaray;
using System;
using System.Windows.Forms;

namespace BudgetApplication
{
    public partial class frmMain : Form
    {
        // instantiate validate class object
        Validate validate = new Validate();

        Handler handler = new Handler();
        
        public frmMain()
        {
            InitializeComponent();
            customiseDesign();

            // disable buttons
            btnGeneral.Enabled = false;
            btnHome.Enabled = false;
            btnVehicle.Enabled = false;
        }

        // hide submenue panels
        private void customiseDesign()
        {
            pnlHomeSubmenue.Visible = false;
        }

        // hide submenu panel that has previous been shown
        private void hideSubMenu()
        {
            if (pnlHomeSubmenue.Visible == true)
            {
                pnlHomeSubmenue.Visible = false;
            }
        }

        // show submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            // hide panel
            panelIncome.Visible = false;

            // hide if any sub menu is open
            hideSubMenu();

            // open new form
            openChildForm(new frmGeneral());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // hide panel
            panelIncome.Visible = false;


            // show the sub menu for home (rent and loan)
            showSubMenu(pnlHomeSubmenue);
        }

        private void btnHomeLoan_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // open new form
            openChildForm(new frmHomeLoan());

        }

        private void btnRentHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // open new form
            openChildForm(new frmHomeRent());

        }

        private void btnVehicle_Click_1(object sender, EventArgs e)
        {
            // hide panel
            panelIncome.Visible = false;

            // hide if any sub menu is open
            hideSubMenu();

            // open new form
            openChildForm(new frmVehicle());
        }

        // declare a field of type form
        private Form activeForm = null;

        // show form
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();

                pnlMainDisplay.Visible = false;

            }

            // hide main display
            pnlMainDisplay.Visible = false;

            // store form that opens to active form
            activeForm = childForm;

            // child form is not of the top level, behave like a control
            childForm.TopLevel = false;

            // remove boarder of form
            childForm.FormBorderStyle = FormBorderStyle.None;

            // set dock to fill container
            childForm.Dock = DockStyle.Fill;

            // add form to list of controls
            pnlChildForm.Controls.Add(childForm);

            // associate form with container panel
            pnlChildForm.Tag = childForm;

            // bring form to front
            pnlChildForm.BringToFront();

            // show child form
            childForm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // show panel
            pnlMainDisplay.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            // show panel
            pnlMainDisplay.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            // show panel
            pnlMainDisplay.Visible = true;
        }


        // declare and initialsie field
        public static double grossIncome { get; set; }
        private void btnNext_Click(object sender, EventArgs e)
        {
                  
            try
            {
                // store user input 
                grossIncome = Convert.ToDouble(txbGrossMonthlyIncome.Text);

                // add to array list
                Handler.arrayList.Add(grossIncome);

           
                // instantiate handler class object from class library
                handler = new Handler(grossIncome);

                // set field
                handler.GrossMonthlyIncome = grossIncome;

                // add gross income to list
                //handler.listIncome.Add(grossMonthlyIncome);

            }
            catch (System.FormatException)
            {


                // validate input
                validate.ValidateUserInterfaceInput(errorProviderGrossMonthlyIncome, txbGrossMonthlyIncome, "Enter Income");

                return;

            }


            if (txbGrossMonthlyIncome.Text.Trim() != string.Empty)
            {
                // clear error
                errorProviderGrossMonthlyIncome.Clear();

                // enable buttons
                btnGeneral.Enabled = true;
                btnHome.Enabled = true;
                btnVehicle.Enabled = true;

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // set date and time
            txbDate.Text = DateTime.Now.ToLongDateString();
            txbTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}



/*
 * Author : RJ Code Advance EN
 * Topic : Modern Flat UI, Drop-down/Slider Menu, Side Menu, Responsive, Only Form - C#, WinForm
 * Code available at : https://www.youtube.com/watch?v=JP5rgXO_5Sk
 * Lines : 7 - 174
 * Date : Sep 17, 2019
 */

/*
 * Author : Tech World
 * Topic : C# - Display Time and Date on labels in Windows form application using C sharp Programming language
 * Code available at : https://www.youtube.com/watch?v=KYRyrKLUcZg
 * Lines : 227-234
 * Date : Sep 7, 2016
 */

/*
 * Author : Nount Project
 * Topic : Picture References
 * Pictures available : https://thenounproject.com/search/?q=reset
 * Date : 2020
 */

/*
 * Acknowledgements:
 * I would like to express my special thanks of gratitude to my teacher (Ebrahim Adam) as well as my tutor (Reuel) who gave me the golden 
 * opportunity to do this wonderful project on the topic (Budget App), which also helped me in doing a lot of Research and i came to know/learn 
 * about so many new things I am really thankful to them for the hours and time sacrifised to assist me at the oddest of times and providing me 
 * with valuable knowledge , information/sources and guidance along the way during this time frame.
 */

/* 
 * Quote : Something is usable if it behaves exactly as expected.”
— Joel Spolsky
 */