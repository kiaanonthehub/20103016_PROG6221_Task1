using System;
using System.Windows.Forms;
using BudgetAppLibaray;

namespace BudgetApplication
{
    public partial class frmVehicle : Form
    {


        public frmVehicle()
        {
            InitializeComponent();

            // hide rich text box
            richTextBoxDisplay.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // declare and initialise fields
            String make = null, model = null;
            double purchaseprice = 0.0, deposit = 0.0, insurancePremium = 0.0;
            int interestRate = 0;

            // set value 
            const int period = 5;

            try
            {

                // store user input
                make = cmbMake.SelectedItem.ToString();
                model = txbModel.Text;
                purchaseprice = Convert.ToDouble(txbPurchasePrice.Text);
                deposit = Convert.ToDouble(txbDeposit.Text);
                interestRate = Convert.ToInt32(txbIntrest);
                insurancePremium = Convert.ToDouble(txbInsurance.Text);


            }
            catch (System.FormatException)
            {

                // instantiate validate class object from class library
                Validate validate = new Validate();

                // validate user input
                validate.ValidateUserInterfaceInput(errorProviderInsurance,txbInsurance,"Invalid Input.");
                validate.ValidateUserInterfaceInput(errorProviderInterest,txbIntrest, "Invalid Input.");
                validate.ValidateUserInterfaceInput(errorProviderDeposit,txbDeposit, "Invalid Input.");
                validate.ValidateUserInterfaceInput(errorProviderPurchasePrice,txbPurchasePrice, "Invalid Input.");
                validate.ValidateUserInterfaceInput(errorProviderModel,txbModel,"Invalid Input.");

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear textboxes
            txbModel.Clear();
            txbPurchasePrice.Clear();
            txbDeposit.Clear();
            txbIntrest.Clear();
            txbInsurance.Clear();
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
 * Author :©2020 Back4App, Inc.
 * Topic : Car Models by Manufacturer, Category, and Year
 * Code available at : https://www.back4app.com/database/back4app/car-make-model-dataset
 * Combo box items 
 * Date : 2020
 */

