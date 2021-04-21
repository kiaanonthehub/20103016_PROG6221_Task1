using BudgetAppLibaray;
using System;
using System.Windows.Forms;

namespace BudgetApplication
{
    public partial class frmHomeLoan : Form
    {
        public frmHomeLoan()
        {
            InitializeComponent();

            // hide rich text box
            richTextBoxDisplay.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // declare and initialise fields
            double purchasePrice = 0.0, deposit = 0.0, intrestRate = 0;
            int noOfMonthlyPayment = 0;

            // instantiate validate class object from class library
            Validate validate = new Validate();

            // error exception handling
            try
            {

                // store user input
                purchasePrice = Convert.ToDouble(txbPurchasePriceProp.Text);
                deposit = Convert.ToDouble(txbDeposit.Text);
                intrestRate = Convert.ToDouble(txbInterestRate.Text);
                noOfMonthlyPayment = Convert.ToInt32(txbNoOfMonthsRepay.Text);


            }
            catch (System.FormatException)
            {

                // validate the user input
                validate.ValidateUserInterfaceInput(errorProviderMonths, txbNoOfMonthsRepay, "Invalid input.");
                validate.ValidateUserInterfaceInput(errorProviderInterest, txbInterestRate, "Invalid input.");
                validate.ValidateUserInterfaceInput(errorProviderDeposit, txbDeposit, "Invalid input.");
                validate.ValidateUserInterfaceInput(errorProviderPurchase, txbPurchasePriceProp, "Invalid input.");

            }

                // validate the no of months the user entered
                validate.ValidateHomeLoanPeriod(errorProviderMonths, txbNoOfMonthsRepay, "Invalid number of monthts.\nPlease select between 240 and 360.", "Invalid Period Input", MessageBoxButtons.OK, MessageBoxIcon.Warning, intrestRate);

            // instantiate homeLoan class object from class library
            HomeLoan homeLoan = new HomeLoan(purchasePrice, deposit, intrestRate, noOfMonthlyPayment);            

            richTextBoxDisplay.Visible = true;
            richTextBoxDisplay.Clear();
            richTextBoxDisplay.AppendText("Home loan with after interest is R" +homeLoan.A
                +"\nHome loan monthly repayment amount : R" + homeLoan.MonthlyHomeLoanRepayment + " per month for " + homeLoan.NoOfMonths + " months");

            // instantiate homeLoan class object from class library
            Handler handler = new Handler();
     
            // loan approval 
            if (homeLoan.MonthlyHomeLoanRepayment > (0.33 * Convert.ToDouble(Handler.arrayList[0])))
            {
                validate.Notify("Your loan is unlikely to be approved", "Loan Approval", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }


            // add homeLoan to generic list
            handler.listExpense.Add(homeLoan);
            frmMain main = new frmMain();
            main.lblAvailableMoney.Text = "R" + (handler.GrossMonthlyIncome - homeLoan.MonthlyHomeLoanRepayment);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear textboxes
            txbPurchasePriceProp.Clear();
            txbDeposit.Clear();
            txbInterestRate.Clear();
            txbNoOfMonthsRepay.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            // show panel
            frmMain main = new frmMain();
            main.pnlMainDisplay.Visible = true;
            main.pnlMainDisplay.BringToFront();
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