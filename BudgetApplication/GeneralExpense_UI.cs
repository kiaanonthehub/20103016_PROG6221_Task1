using System;
using System.Windows.Forms;
using BudgetAppLibaray;

namespace BudgetApplication
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();

            // hide rich text box
            richTextBoxDisplay.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // declare and initialise fields
            double taxDeduction = 0.0, groceries = 0.0, waterAndLights = 0.0, travleCosts = 0.0, phone = 0.0, other = 0.0;

            // error exception handling
            try
            {

            // store user input
            taxDeduction = Convert.ToDouble(txbMonthlyTaxDeduction.Text);
            groceries = Convert.ToDouble(txbGroceries.Text);
            waterAndLights = Convert.ToDouble(txbWaterLights.Text);
            travleCosts = Convert.ToDouble(txbTravelCost.Text);
            phone = Convert.ToDouble(txbPhone.Text);
            other = Convert.ToDouble(txbOtherExpense.Text);

            }
            catch (System.FormatException)
            {

            // instantiate validate class object from class library
            Validate validate = new Validate();

            // validate the users input
            validate.ValidateUserInterfaceInput(errorProviderOther,txbOtherExpense,"Invalid input.");
            validate.ValidateUserInterfaceInput(errorProviderPhone,txbPhone, "Invalid input.");
            validate.ValidateUserInterfaceInput(errorProviderTravel,txbTravelCost, "Invalid input.");
            validate.ValidateUserInterfaceInput(errorProviderWater,txbWaterLights, "Invalid input.");
            validate.ValidateUserInterfaceInput(errorProviderGroceries,txbGroceries, "Invalid input.");
            validate.ValidateUserInterfaceInput(errorProviderTax,txbMonthlyTaxDeduction, "Invalid input.");

            }

            // instantiate generalExpense class object from class library
            GeneralExpense generalExpense = new GeneralExpense(taxDeduction, groceries, waterAndLights, travleCosts, phone, other);

            // instantiate object of main class
            double grossIncome = frmMain.grossIncome;
            
            // instantiate handler class object from class library
            Handler handler = new Handler(grossIncome);
         
            // add generalExpense to generic list
            handler.listExpense.Add(generalExpense);

            richTextBoxDisplay.Visible = true;

            richTextBoxDisplay.Clear();

            richTextBoxDisplay.AppendText("\nGross Monthlly Income : R"+handler.GrossMonthlyIncome);

            richTextBoxDisplay.AppendText("\nTotal General Expense : R" + generalExpense.GeneralTotalExpense);

            richTextBoxDisplay.AppendText("\nAvailable Money (after general exxpense deduction) : R" + handler.handleAvailableMoneyGeneralExpense());

            frmMain main = new frmMain();
            main.lblAvailableMoney.Text = "R" + handler.handleAvailableMoneyGeneralExpense();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            // clear textboxes
            txbMonthlyTaxDeduction.Clear();
            txbGroceries.Clear();
            txbTravelCost.Clear();
            txbWaterLights.Clear();
            txbPhone.Clear();
            txbOtherExpense.Clear();
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
 * Date : Sep 17, 2019
 */