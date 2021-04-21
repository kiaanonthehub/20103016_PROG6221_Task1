// TASK 1

namespace BudgetAppLibaray
{
    // base abstract class
    public abstract class Expense
    {
        // private fields
        private double totalExpense;

        // get and set methods
        public double TotalExpense { get => totalExpense; set => totalExpense = value; }

        // abstract method
        public abstract double CalculateTotalExpense();
    }
}
