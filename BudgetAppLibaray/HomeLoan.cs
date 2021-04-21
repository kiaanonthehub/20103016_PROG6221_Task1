// TASK 1

namespace BudgetAppLibaray
{
    // derived class from loan expense
    public class HomeLoan : LoanExpense
    {
        // private field
        private double monthlyHomeLoanRepayment;

        // constructor 
        public HomeLoan(double purchasePrice, double totalDeposit, double interestRate, int noOfMonths) : base(purchasePrice, totalDeposit, interestRate, noOfMonths)
        {
            // method call
            monthlyHomeLoanRepayment = LoanRepayment();
        }

        // getter and setters
        public double MonthlyHomeLoanRepayment { get => monthlyHomeLoanRepayment; set => monthlyHomeLoanRepayment = value; }

        // method that calculates the monthly home loan repayment
        public override double LoanRepayment()
        {
            // conversion
            P = PurchasePrice - TotalDeposit;
            I = InterestRate / 100;
            N = NoOfMonths / 12;

            // simple interest 
            A = P * (1 + (I * N));

            // calculate monthly repayment for (x) number of months
            MonthlyHomeLoanRepayment = A / NoOfMonths;

            return MonthlyHomeLoanRepayment;
        }
    }
}

/*
 * Author : sanfoundary.com
 * Topic : C# Program to Calculate Simple Interest
 * Sample : interest = princamt * year * rate / 100;
            total_amt = princamt + interest;
 * Code available at :https://www.sanfoundry.com/csharp-program-simple-interest/
 * Date : April 2020
 */