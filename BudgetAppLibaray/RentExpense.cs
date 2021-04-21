namespace BudgetAppLibaray
{
    public class RentExpense : Expense
    {
        // private field
        private double monthlyRent;

        // constructor
        public RentExpense(double monthlyRent)
        {
            this.monthlyRent = CalculateTotalExpense();
        }

        // get and set fields
        public double MonthlyRent
        {
            get => monthlyRent; set => monthlyRent = value;
        }

        public override double CalculateTotalExpense()
        {
            return monthlyRent;
        }
    }
}
