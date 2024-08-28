using System;
using System.Collections.Generic;

namespace ShoppingCart
{	

	/*Question 9
9.	Implement a shopping cart system where a user can add items, remove items, and view the total price. Assume each item has a name and a price.;
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize shopping cart
            List<Item> cart = new List<Item>();

            while (true)
            {
                Console.WriteLine("Shopping Cart Menu:");
                Console.WriteLine("1. Add item to cart");
                Console.WriteLine("2. Remove item from cart");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddItemToCart(cart);
                        break;
                    case 2:
                        RemoveItemFromCart(cart);
                        break;
                    case 3:
                        ViewCart(cart);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddItemToCart(List<Item> cart)
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter item price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Item item = new Item(name, price);
            cart.Add(item);

            Console.WriteLine($"Item '{name}' added to cart.");
        }

        static void RemoveItemFromCart(List<Item> cart)
        {
            Console.Write("Enter item name to remove: ");
            string name = Console.ReadLine();

            Item itemToRemove = cart.Find(i => i.Name == name);

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Console.WriteLine($"Item '{name}' removed from cart.");
            }
            else
            {
                Console.WriteLine($"Item '{name}' not found in cart.");
            }
        }

        static void ViewCart(List<Item> cart)
        {
            Console.WriteLine("Shopping Cart:");
            double totalPrice = 0;

            foreach (Item item in cart)
            {
                Console.WriteLine($"  {item.Name}: {item.Price:F2}");
                totalPrice += item.Price;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}