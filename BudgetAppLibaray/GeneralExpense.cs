// TASK 1

namespace BudgetAppLibaray
{
    // derived class of expense
    public class GeneralExpense : Expense
    {
        // private fields
        private double taxDeduction;
        private double groceries;
        private double waterAndLights;
        private double travelling;
        private double communication;
        private double other;
        private double generalTotalExpense;

        // class constructor
        public GeneralExpense(double taxDeduction, double groceries, double waterAndLights, double travelling, double communication, double other)
        {
            this.taxDeduction = taxDeduction;
            this.groceries = groceries;
            this.waterAndLights = waterAndLights;
            this.travelling = travelling;
            this.communication = communication;
            this.other = other;

            // CalculateMonthlyExpense method call
            generalTotalExpense = CalculateTotalExpense();
        }

        // getters and setters
        public double TaxDeduction { get => taxDeduction; set => taxDeduction = value; }
        public double Groceries { get => groceries; set => groceries = value; }
        public double WaterAndLights { get => waterAndLights; set => waterAndLights = value; }
        public double Travelling { get => travelling; set => travelling = value; }
        public double Communication { get => communication; set => communication = value; }
        public double Other { get => other; set => other = value; }
        public double GeneralTotalExpense { get => generalTotalExpense; set => generalTotalExpense = value; }

        // calculates and returns the total monthly expense for general expense class
        public override double CalculateTotalExpense()
        {
            return (taxDeduction + groceries + waterAndLights + travelling + communication + other);
        }
    }
}



