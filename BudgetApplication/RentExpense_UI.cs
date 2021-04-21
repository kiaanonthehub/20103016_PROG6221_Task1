using BudgetAppLibaray;
using System;
using System.Windows.Forms;

namespace BudgetApplication
{
    public partial class frmHomeRent : Form
    {
        public frmHomeRent()
        {
            InitializeComponent();

            // hide rich text box
            richTextBoxDisplay.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // declare and initialise fields
            double monthlyRental = 0.0;

            // error exception handling
            try
            {

                // store user input
                monthlyRental = Convert.ToDouble(txbMonthlyRentalAmount.Text);

            }
            catch (System.FormatException)
            {

                // instantiate validate class object from class library
                Validate validate = new Validate();
                validate.ValidateUserInterfaceInput(errorProviderRent, txbMonthlyRentalAmount, "Invalid input.");

            }

            // instantiate rentExpense class object from class library
            RentExpense rentExpense = new RentExpense(monthlyRental);

            // instantiate handler class object from class library
            Handler handler = new Handler();

            // add rentExpense to generic list
            handler.listExpense.Add(rentExpense);

            // clear display
            richTextBoxDisplay.Clear();

            richTextBoxDisplay.Visible = true;

            // display
            richTextBoxDisplay.AppendText("Your monthly rent will be R"+monthlyRental);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear textboxes
            txbMonthlyRentalAmount.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // show panel
            frmMain main = new frmMain();
            main.pnlMainDisplay.Visible = true;
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