using System;

namespace DominonaPizzaKiosk
{
    public class Checkout
    {
        public static OrderService OrderRecords = new OrderService();

        public static bool Process(Cart cart)
        {
            if (cart.ItemCount == 0)
            {
                Console.WriteLine("Your cart is empty!");
                Console.ReadKey();
                return false;
            }

            cart.DisplayCart();

            Console.Write("\nEnter payment amount: ");
            double payment;

            if (!double.TryParse(Console.ReadLine(), out payment)
                || payment <= 0)
            {
                Console.WriteLine("Invalid payment!");
                Console.ReadKey();
                return false;
            }

            if (payment < cart.GetTotal())
            {
                Console.WriteLine("Insufficient payment!");
                Console.ReadKey();
                return false;
            }

            Order order = OrderRecords.CreateOrder(cart, payment);

            if (order != null)
            {
                cart.ClearCart();
                Receipt.Print(order);
                return true;
            }

            Console.WriteLine("Unable to process order!");
            Console.ReadKey();
            return false;
        }
    }
}
