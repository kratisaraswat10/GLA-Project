using System;

namespace ShoppingCart
{
		/*  Question 1
  1.	Write a C# program to calculate the total price of items in a shopping cart. The cart contains 5 items with different prices. Include a 10% discount if the total price exceeds Rs. 3000;*/
    class Program
    {
        static void Main(string[] args)
        {
            // Define the prices of the 5 items in the cart
            decimal item1Price = 500;
            decimal item2Price = 800;
            decimal item3Price = 200;
            decimal item4Price = 1200;
            decimal item5Price = 400;

            // Calculate the total price
            decimal totalPrice = item1Price + item2Price + item3Price + item4Price + item5Price;

            // Check if the total price exceeds Rs. 3000
            if (totalPrice > 3000)
            {
                // Calculate the 10% discount
                decimal discount = totalPrice * 0.10m;

                // Calculate the final price with discount
                totalPrice -= discount;

                Console.WriteLine("Total price with 10% discount: Rs. " + totalPrice);
            }
            else
            {
                Console.WriteLine("Total price: Rs. " + totalPrice);
            }

            Console.ReadLine();
        }
    }
}