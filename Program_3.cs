using System;

namespace ATM
{	
	/*Question 3
3.	Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money, and withdraw money. Ensure that the program checks for sufficient funds before allowing a withdrawal;
*/
    class Program
    {
        static double balance = 0.0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!");

            while (true)
            {
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance:F2}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit successful. Your new balance is: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please try again.");
            }
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance:F2}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Please try again.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please try again.");
            }
        }
    }
}