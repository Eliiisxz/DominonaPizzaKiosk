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

                Console.WriteLine("========================================");
                Console.WriteLine("           DOMINONA PIZZA");
                Console.WriteLine("          SELF-SERVICE KIOSK");
                Console.WriteLine("========================================");

                Console.WriteLine("\n              WELCOME!");

                Console.WriteLine("\n       [1] CUSTOMER");
                Console.WriteLine("       [2] CASHIER");
                Console.WriteLine("       [3] EXIT");

                Console.Write("\nSelect your option: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
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
                        Console.WriteLine(
                            "Thank you for visiting Dominona Pizza!"
                        );
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
