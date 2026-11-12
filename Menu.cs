using System;

namespace DominonaPizzaKiosk
{
    public class Menu
    {
        public static Product[] Products =
        {
            new Product("Pepperoni Pizza", "Pizza", 299),
            new Product("Hawaiian Pizza", "Pizza", 279),
            new Product("Cheese Pizza", "Pizza", 249),

            new Product("Carbonara", "Pasta", 159),
            new Product("Spaghetti", "Pasta", 139),

            new Product("Fried Chicken", "Chicken", 99),
            new Product("Chicken Wings", "Chicken", 129),

            new Product("French Fries", "Sides", 79),
            new Product("Mozzarella Sticks", "Sides", 99),

            new Product("Coke", "Drinks", 45),
            new Product("Iced Tea", "Drinks", 40),
            new Product("Water", "Drinks", 25),

            new Product("Chocolate Cake", "Desserts", 89),
            new Product("Brownies", "Desserts", 69)
        };

        public static void ShowMenu(Cart cart)
        {
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("========================================");
                Console.WriteLine("          DOMINONA PIZZA KIOSK");
                Console.WriteLine("========================================");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n              CUSTOMER MENU");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------------");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("              AVAILABLE PRODUCTS");

                string[] categories =
                {
                    "Pizza", "Pasta", "Chicken",
                    "Sides", "Drinks", "Desserts"
                };

                for (int c = 0; c < categories.Length; c++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n--- " + categories[c] + " ---");

                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < Products.Length; i++)
                    {
                        if (Products[i].Category == categories[c])
                        {
                            Console.WriteLine(
                                "[" + (i + 1) + "] " +
                                Products[i].Name +
                                " - PHP " + Products[i].Price
                            );
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n----------------------------------------");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[0] Checkout");
                Console.WriteLine("[99] Back to Main Menu");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nSelect product: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 99)
                {
                    return;
                }

                if (choice == 0)
                {
                    if (Checkout.Process(cart))
                    {
                        return;
                    }

                    continue;
                }

                if (choice < 1 || choice > Products.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid product!");
                    Console.ReadKey();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter quantity: ");

                int quantity;

                if (!int.TryParse(Console.ReadLine(), out quantity)
                    || quantity <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid quantity!");
                    Console.ReadKey();
                    continue;
                }

                cart.AddProduct(Products[choice - 1], quantity);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nProduct added successfully!");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
