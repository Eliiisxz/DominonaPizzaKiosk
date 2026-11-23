using System;

namespace DominonaPizzaKiosk
{
    public class Checkout
    {
        public static OrderService OrderRecords = new OrderService();

        public static bool Process(Cart cart, string orderType)
        {
            if (cart.ItemCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your cart is empty!");
                Console.ReadKey();
                return false;
            }

            while (true)
            {
                cart.DisplayCart();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Order Type: " + orderType);
                Console.WriteLine(
                    "Total Amount: PHP " + cart.GetTotal().ToString("F2")
                );

                Console.Write("\nEnter your payment: PHP ");

                double payment;

                if (!double.TryParse(Console.ReadLine(), out payment)
                    || payment <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid payment!");
                    Console.WriteLine("Please enter a valid amount.");
                    Console.ReadKey();
                    continue;
                }

                if (payment < cart.GetTotal())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInsufficient payment!");
                    Console.WriteLine("Please enter enough money.");
                    Console.WriteLine("\nPress any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                Order order = OrderRecords.CreateOrder(
                    cart,
                    payment,
                    orderType
                );

                if (order != null)
                {
                    cart.ClearCart();
                    Receipt.Print(order);
                    return true;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUnable to process order!");
                Console.ReadKey();
                return false;
            }
        }
    }
}
