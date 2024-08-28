using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{	

	/*Question 5
5.	Develop a C# application that asks the user to enter a password. The password should be validated based on the following criteria: at least 8 characters long, contains at least one uppercase letter, one lowercase letter, and one number. Display appropriate messages based on the validation result;
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool isValid = ValidatePassword(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is not valid. Please ensure it meets the following criteria:");
                Console.WriteLine("  * At least 8 characters long");
                Console.WriteLine("  * Contains at least one uppercase letter");
                Console.WriteLine("  * Contains at least one lowercase letter");
                Console.WriteLine("  * Contains at least one number");
            }
        }

        static bool ValidatePassword(string password)
        {
            // Check length
            if (password.Length < 8)
            {
                return false;
            }

            // Check for uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return false;
            }

            // Check for lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return false;
            }

            // Check for number
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                return false;
            }

            return true;
        }
    }
}