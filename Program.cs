using System;

namespace DominonaPizzaKiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("========================================");
                Console.WriteLine("          DOMINONA PIZZA KIOSK");
                Console.WriteLine("========================================");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n       SELF-SERVICE ORDERING SYSTEM");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n              WELCOME!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n----------------------------------------");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           [1] CUSTOMER");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("           [2] CASHIER");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("           [3] EXIT");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("----------------------------------------");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nSelect your option: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input!");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Cart cart = new Cart();
                        Menu.ShowMenu(cart);
                        break;

                    case 2:
                        Cashier.ShowOrders();
                        break;

                    case 3:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("========================================");
                        Console.WriteLine("       THANK YOU FOR VISITING!");
                        Console.WriteLine("          DOMINONA PIZZA");
                        Console.WriteLine("========================================");

                        Console.ResetColor();
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid choice!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
