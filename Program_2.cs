using System;

namespace TemperatureConverter
{	 
	/*Question 2
2.	Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit. If the input temperature is below 0°C, display a warning message about freezing temperatures;
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            if (celsius < 0)
            {
                Console.WriteLine("Warning: Freezing temperatures!");
            }

            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}