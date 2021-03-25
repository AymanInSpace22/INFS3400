using System;
using static System.Console;

namespace ConsoleApp1
{

    //Monthly sales tax report
    //Prompt user for total sales for the month
    //Calculate the county tax and state tax amount
    //County tax rate is 2.5%   State tax rate is 5%
    //Display the following:
    //The amount of county sales tax
    //The amount of state sales tax
    //The total sales tax

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleae enter the total sales for the month >> ");
            double totalSalesForMonth = double.Parse(ReadLine());

            double countySalesTax = CalculateCountySalesTax(totalSalesForMonth);
            double stateSalesTax = CalculateStateSalesTax(totalSalesForMonth);
            double totalSalesTax = CalculateTotalSalesTax(stateSalesTax, countySalesTax);
            DisplaySalesTaxReport(countySalesTax, stateSalesTax, totalSalesTax);

            ReadLine();
        }

        public static double CalculateCountySalesTax(double totalSalesForMonth)
        {
            const double COUNTYRATE = (2.5 / 100);
            double countySalesTax = COUNTYRATE * totalSalesForMonth;
            return countySalesTax;
        }

        public static double CalculateStateSalesTax(double totalSalesForMonth)
        {
            const double STATERATE = (5.0 / 100);
            double stateSalesTax = STATERATE * totalSalesForMonth;
            return stateSalesTax;
        }

        public static double CalculateTotalSalesTax(double stateSalesTax, double countySalesTax)
        {
            double totalSalesTax = stateSalesTax + countySalesTax;
            return totalSalesTax;
        }

        public static void DisplaySalesTaxReport(double countySalesTax, double stateSalesTax, double totalSalesTax)
        {
            WriteLine("Monthly Sales Tax Report - Created on: " + DateTime.Now.ToString("d"));
            WriteLine("User Name: {0}", Environment.UserName);
            WriteLine("\nCounty Sales Tax: {0}", countySalesTax.ToString("C"));
            WriteLine("State Sales Tax: {0}", stateSalesTax.ToString("C"));
            WriteLine("Total Sales Tax: {0}", totalSalesTax.ToString("C"));
        }
    }
}
