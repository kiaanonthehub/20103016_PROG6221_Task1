// TASK 2

namespace BudgetAppLibaray
{
    // derived class from loan expense
    public class VehicleLoan : LoanExpense
    {
        // private fields
        private double insurancePremium;
        private double vehicleLoanRepayment;
        private string model;
        private string make;

        // constructor 
        public VehicleLoan(string model, string make, double purchasePrice, double totalDeposit, int interestRate, int noOfMonths, double insurancePremium) : base(purchasePrice, totalDeposit, interestRate, noOfMonths)
        {
            this.insurancePremium = insurancePremium;
            this.model = model;
            this.make = make;

            // method call
            vehicleLoanRepayment = LoanRepayment();
        }

        // get and set method
        public double InsurancePremium { get => insurancePremium; set => insurancePremium = value; }
        public double VehicleLoanRepayment { get => vehicleLoanRepayment; set => vehicleLoanRepayment = value; }
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }

        // method that calculates the monthly home loan repayment
        public override double LoanRepayment()
        {
            // conversion
            P = PurchasePrice - TotalDeposit;
            I = InterestRate / 100;
            N = 5;

            // simple interest 
            A = P * (1 + (I * N));

            // calculate monthly repayment for (x) number of months
            vehicleLoanRepayment = (A / (N * 12)) + insurancePremium;

            return vehicleLoanRepayment;
        }

    }
}
