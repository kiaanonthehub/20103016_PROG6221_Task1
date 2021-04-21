// TASK 1

namespace BudgetAppLibaray
{
    // derived abstract class from expense
    // abstract base class for Loan
    public abstract class LoanExpense : Expense
    {
        // private fields
        private double purchasePrice;
        private double totalDeposit;
        private double interestRate;
        private int noOfMonths;

        // private conversion fields
        private double a;
        private double p;
        private double i;
        private int n;

        // constructor 
        protected LoanExpense(double purchasePrice, double totalDeposit, double interestRate, int noOfMonths)
        {
            PurchasePrice = purchasePrice;
            TotalDeposit = totalDeposit;
            InterestRate = interestRate;
            NoOfMonths = noOfMonths;
        }

        // getters and setters
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double TotalDeposit { get => totalDeposit; set => totalDeposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int NoOfMonths { get => noOfMonths; set => noOfMonths = value; }

        public double A { get => a; set => a = value; }
        public double P { get => p; set => p = value; }
        public double I { get => i; set => i = value; }
        public int N { get => n; set => n = value; }

        // calculates and returns the total monthly expense for loan expense class
        public override double CalculateTotalExpense()
        {
            return 0;
        }

        // abstract method
        public abstract double LoanRepayment();

    }
}
