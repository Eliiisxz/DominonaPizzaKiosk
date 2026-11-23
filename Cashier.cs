using System;

namespace DominonaPizzaKiosk
{
    public class Cashier
    {
        public static void ShowOrders()
        {
            OrderService service = Checkout.OrderRecords;

            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("========================================");
                Console.WriteLine("          DOMINONA PIZZA KIOSK");
                Console.WriteLine("             CASHIER DASHBOARD");
                Console.WriteLine("========================================");

                if (service.OrderCount == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo orders available.");
                }

                for (int i = 0; i < service.OrderCount; i++)
                {
                    Order order = service.GetOrder(i);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nOrder #" + order.OrderNumber);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Order Type: " + order.OrderType);

                    Console.WriteLine("Products:");

                    for (int j = 0; j < order.Items.Length; j++)
                    {
                        Console.WriteLine(
                            "- " + order.Items[j].Product.Name +
                            " x" + order.Items[j].Quantity
                        );
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "Total: PHP " + order.Total.ToString("F2")
                    );

                    Console.WriteLine("Status: " + order.Status);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------");
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[0] Back to Main Menu");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEnter Order Number to update: ");

                int number;

                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                    continue;
                }

                if (number == 0)
                {
                    return;
                }

                Order selected = null;

                for (int i = 0; i < service.OrderCount; i++)
                {
                    if (service.Orders[i].OrderNumber == number)
                    {
                        selected = service.Orders[i];
                        break;
                    }
                }

                if (selected == null)
                {
                    Console.WriteLine("Order not found!");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("========================================");
                Console.WriteLine("              UPDATE ORDER");
                Console.WriteLine("========================================");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Order Number: " + selected.OrderNumber);
                Console.WriteLine("Order Type: " + selected.OrderType);

                Console.WriteLine("\n[1] Preparing");
                Console.WriteLine("[2] Ready");
                Console.WriteLine("[3] Completed");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nSelect new status: ");

                int status;

                if (!int.TryParse(Console.ReadLine(), out status))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                    continue;
                }

                switch (status)
                {
                    case 1:
                        selected.Status = "Preparing";
                        break;

                    case 2:
                        selected.Status = "Ready";
                        break;

                    case 3:
                        selected.Status = "Completed";
                        break;

                    default:
                        Console.WriteLine("Invalid status!");
                        Console.ReadKey();
                        continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nOrder status updated successfully!");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
