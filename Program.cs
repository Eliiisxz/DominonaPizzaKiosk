
using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       DOMINONA PIZZA");
            Console.WriteLine("        SELF-SERVICE");
            Console.WriteLine("================================");

            Console.WriteLine();
            Console.WriteLine("Welcome to Dominona Pizza!");
            Console.WriteLine();
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Cashier");
            Console.WriteLine("3. Exit");

            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Welcome, Customer!");
                    Console.WriteLine("Opening Pizza Menu...");
                    break;

                case "2":
                    Console.WriteLine("Welcome, Cashier!");
                    Console.WriteLine("Opening Cashier Dashboard...");
                    break;

                case "3":
                    Console.WriteLine("Thank you for visiting Dominona Pizza!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}
