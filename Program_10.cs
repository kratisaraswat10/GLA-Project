using System;

namespace MonthlySalaryCalculator
{	

	/*Question 10
10.	Create a program that calculates the monthly salary of an employee based on their hourly wage and the number of hours worked in a week. Consider that there are 4 weeks in a month;
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hourly wage: ");
            double hourlyWage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number of hours worked in a week: ");
            double hoursWorkedPerWeek = Convert.ToDouble(Console.ReadLine());

            double monthlySalary = CalculateMonthlySalary(hourlyWage, hoursWorkedPerWeek);

            Console.WriteLine($"Monthly salary: {monthlySalary:F2}");
        }

        static double CalculateMonthlySalary(double hourlyWage, double hoursWorkedPerWeek)
        {
            const int weeksInAMonth = 4;
            double monthlySalary = hourlyWage * hoursWorkedPerWeek * weeksInAMonth;

            return monthlySalary;
        }
    }
}