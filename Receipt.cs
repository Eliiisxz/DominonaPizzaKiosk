using System;

namespace DominonaPizzaKiosk
{
    public class Receipt
    {
        public static void Print(Order order)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("          DOMINONA PIZZA KIOSK");
            Console.WriteLine("                 RECEIPT");
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Order Number: " + order.OrderNumber);
            Console.WriteLine("Order Type: " + order.OrderType);

            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < order.Items.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(order.Items[i].Product.Name);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Quantity: " + order.Items[i].Quantity);

                Console.WriteLine(
                    "Subtotal: PHP " +
                    order.Items[i].GetSubtotal().ToString("F2")
                );

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "TOTAL: PHP " + order.Total.ToString("F2")
            );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "Payment: PHP " + order.Payment.ToString("F2")
            );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "Change: PHP " + order.Change.ToString("F2")
            );

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       THANK YOU FOR ORDERING!");
            Console.WriteLine("          DOMINONA PIZZA");
            Console.WriteLine("========================================");

            Console.ResetColor();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
