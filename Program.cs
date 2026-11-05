

using System;

class Program
{
    static void Main()
    {
        string choice = FormWelcome.ShowWelcome();

        if (choice == "1")
        {
            Console.Clear();
            Console.WriteLine("CUSTOMER MENU");
            Console.WriteLine("Welcome, Customer!");
            Console.WriteLine("The pizza menu will be added here.");
        }
        else if (choice == "2")
        {
            Console.Clear();
            Console.WriteLine("CASHIER DASHBOARD");
            Console.WriteLine("Welcome, Cashier!");
        }
        else if (choice == "3")
        {
            Console.WriteLine("Thank you for visiting Dominona Pizza!");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
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
