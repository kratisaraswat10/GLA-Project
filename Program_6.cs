using System;

namespace TaxiFareCalculator
{	

	/*Question 6
6.	Write a C# program to calculate the fare of a taxi ride. The fare is calculated based on the distance traveled. The first 2 kilometers are charged at a flat rate (Rs. 20), and any additional kilometers are charged at a per-kilometer rate. Include a night surcharge if the ride occurs after 10 PM.;
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance traveled (in kilometers): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time of day (HH:mm): ");
            string time = Console.ReadLine();

            double fare = CalculateFare(distance, time);

            Console.WriteLine($"The fare for the taxi ride is: Rs. {fare:F2}");
        }

        static double CalculateFare(double distance, string time)
        {
            const double flatRate = 20;
            const double perKilometerRate = 10;
            const double nightSurcharge = 10;

            double fare = 0;

            // Calculate fare for first 2 kilometers
            fare += flatRate;

            // Calculate fare for additional kilometers
            if (distance > 2)
            {
                fare += (distance - 2) * perKilometerRate;
            }

            // Apply night surcharge if ride occurs after 10 PM
            if (IsNightTime(time))
            {
                fare += nightSurcharge;
            }

            return fare;
        }

        static bool IsNightTime(string time)
        {
            int hour = Convert.ToInt32(time.Split(':')[0]);

            return hour >= 22; // 10 PM
        }
    }
}