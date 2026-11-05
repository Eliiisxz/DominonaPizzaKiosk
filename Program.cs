

using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            FormWelcome.ShowWelcome();

            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Cashier");
            Console.WriteLine("3. Exit");

            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nWelcome, Customer!");
                    Console.WriteLine("Opening Pizza Menu...");
                    break;

                case "2":
                    Console.WriteLine("\nWelcome, Cashier!");
                    Console.WriteLine("Opening Cashier Dashboard...");
                    break;

                case "3":
                    Console.WriteLine("\nThank you for visiting!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid choice.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}
