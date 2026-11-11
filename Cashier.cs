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

                Console.WriteLine("================================");
                Console.WriteLine("       CASHIER DASHBOARD");
                Console.WriteLine("================================");

                if (service.OrderCount == 0)
                {
                    Console.WriteLine("No orders available.");
                }

                for (int i = 0; i < service.OrderCount; i++)
                {
                    Order order = service.GetOrder(i);

                    Console.WriteLine(
                        "Order #" + order.OrderNumber +
                        " | PHP " + order.Total.ToString("F2") +
                        " | " + order.Status
                    );
                }

                Console.WriteLine("\n[0] Back to Main Menu");
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

                Console.WriteLine("\n[1] Preparing");
                Console.WriteLine("[2] Ready");
                Console.WriteLine("[3] Completed");

                Console.Write("Select new status: ");

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

                Console.WriteLine("Order status updated!");
                Console.ReadKey();
            }
        }
    }
}
