// TASK 1/2

using System;
using System.Windows.Forms;

namespace BudgetAppLibaray
{
    // validate class - used by UI
    public class Validate
    {
        // validates user input in user interface
        public void ValidateUserInterfaceInput(ErrorProvider errorProvider, TextBox textbox, String message)
        {
            if (textbox.Text == string.Empty)
            {
                textbox.Focus();
                errorProvider.SetError(textbox, message);
            }
            else
            { errorProvider.Clear(); }
        }

        // validates user input in user interface
        public void ValidateHomeLoanPeriod(ErrorProvider errorProvider, TextBox textbox, string message, string title, MessageBoxButtons buttonType, MessageBoxIcon iconType, double value)
        {

            try
            {
                while (Convert.ToInt32(textbox.Text) < 240 || Convert.ToInt32(textbox.Text) > 360)
                {
                    Notify(message, title, buttonType, iconType);

                    errorProvider.Clear();

                    errorProvider.SetError(textbox, message);
                    textbox.Focus();

                    break;

                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Home loan period input. ");
            }
        }

        // display a notofication message/error message/warning message
        public void Notify(string message, string title, MessageBoxButtons buttonType, MessageBoxIcon iconType)
        {
            MessageBox.Show(message, title, buttonType, iconType);
        }
    }
}

/*
 * Author : fanton
 * Topic : Check null input c#
 * Line : 12 - 21
 * Code available at : https://stackoverflow.com/questions/35258364/c-how-to-check-for-user-null-input
 * Answered : answered Feb 7 '16 at 20:09
 * Sample : if (arg == NULL || !strcmp(arg, ""))
            return root;
 * Date : April 2020
 */

/*
 * Author : Anoop Kumar Sharma
 * Topic : Error Provider in a C# Windows Forms Application
 * Code available at : https://www.c-sharpcorner.com/UploadFile/1e050f/error-provider-in-C-Sharpwindows-form-application/
 * Sample : errorProvider1.SetError(txt_name,"Please Enter Name");
 * Lines : 9 - 21
 * Date : Updated date Sep 21, 2013
 */