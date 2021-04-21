// TASK 1/2

using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetAppLibaray
{
    // handler class
    public class Handler
    {
        // generic list of type class
        public List<Expense> listExpense = new List<Expense>();

        public static ArrayList arrayList = new ArrayList();
       
        // private fields
        private double availableMoney;
        private double expense;
        private double grossMonthlyIncome;

        // constructor  - used by UI
        public Handler()
        {
            availableMoney = handleAvailableMoneyGeneralExpense();
           //expense = handleTotalExpense(); task 2
        }

        // constructor
        public Handler(double grossMonthlyIncome)
        {
            this.grossMonthlyIncome = grossMonthlyIncome;
            availableMoney = handleAvailableMoneyGeneralExpense();
            expense = handleTotalExpense();
        }

        // getter and setters
        public double AvailableMoney { get => availableMoney; set => availableMoney = value; }
        public double Expense { get => expense; set => expense = value; }
        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }


        // handle - calculate the available monthly money after all the specified deductions have been made. - task1
        public double handleAvailableMoneyGeneralExpense()
        {
            double availableMoney = 0;

            foreach (GeneralExpense item in listExpense)
            {
                availableMoney += item.TaxDeduction;
                availableMoney += item.Groceries;
                availableMoney += item.Communication;
                availableMoney += item.WaterAndLights;
                availableMoney += item.Travelling;
                availableMoney += item.Other;              
            }

            return grossMonthlyIncome - availableMoney;
        }

        public double handleAvailableMoneyLoanExpense()
        {
            double availableMoney = 0;

            foreach (HomeLoan item in listExpense)
            {

                availableMoney = item.MonthlyHomeLoanRepayment;
            }

            return availableMoney;
        }

        // handle - The software shall notify the user when the total expenses, including loan repayments, exceed 75% of their income - task 2
        public double handleTotalExpense()
        {
            // declare and initialise fields
            double income = 0.0, totalExpense = 0.0, generalExpense = 0.0, vehicleExpense = 0.0, homeLoanExpense = 0.0, rentExpense = 0.0;

            // loop through general expense
            foreach (GeneralExpense general in listExpense)
            {
                generalExpense += general.TotalExpense;
            }

            // loop through home loan
            foreach (HomeLoan home in listExpense)
            {
                homeLoanExpense += home.MonthlyHomeLoanRepayment;
            }

            // loop through vehicle
            foreach (VehicleLoan vehicle in listExpense)
            {
                vehicleExpense += vehicle.VehicleLoanRepayment;
            }

            // loop through rent
            foreach (RentExpense rent in listExpense)
            {
                rentExpense += rent.MonthlyRent;
            }

            // still working on this

            totalExpense = generalExpense + homeLoanExpense + vehicleExpense + rentExpense;

            return 0;
        }
    }
}

/*
 * Author : w3schools.com
 * Topic : foreach loop c#
 * Code available at : https://www.w3schools.com/cs/cs_for_loop.asp
 * Date : April 2020
 */
