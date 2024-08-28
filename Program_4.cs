using System;

namespace GradeCalculator
{		

	/*Question 4
4.	Write a C# program to take the marks of five subjects from a user and calculate the average. Based on the average, determine and display the grade (A, B, C, D, or F).;
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks for five subjects:");

            double mark1 = GetMark("Subject 1: ");
            double mark2 = GetMark("Subject 2: ");
            double mark3 = GetMark("Subject 3: ");
            double mark4 = GetMark("Subject 4: ");
            double mark5 = GetMark("Subject 5: ");

            double average = CalculateAverage(mark1, mark2, mark3, mark4, mark5);

            string grade = DetermineGrade(average);

            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Grade: {grade}");
        }

        static double GetMark(string prompt)
        {
            Console.Write(prompt);
            double mark = Convert.ToDouble(Console.ReadLine());

            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("Invalid mark. Please enter a value between 0 and 100.");
                return GetMark(prompt);
            }

            return mark;
        }

        static double CalculateAverage(params double[] marks)
        {
            double sum = 0;

            foreach (double mark in marks)
            {
                sum += mark;
            }

            return sum / marks.Length;
        }

        static string DetermineGrade(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}