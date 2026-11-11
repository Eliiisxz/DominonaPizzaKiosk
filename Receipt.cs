using System;

namespace DominonaPizzaKiosk
{
    public class Receipt
    {
        public static void Print(Order order)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("         DOMINONA PIZZA");
            Console.WriteLine("             RECEIPT");
            Console.WriteLine("================================");

            Console.WriteLine("Order Number: " + order.OrderNumber);
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < order.Items.Length; i++)
            {
                Console.WriteLine(
                    order.Items[i].Product.Name +
                    " x" + order.Items[i].Quantity
                );

                Console.WriteLine(
                    "Subtotal: PHP " +
                    order.Items[i].GetSubtotal().ToString("F2")
                );
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Total: PHP " + order.Total.ToString("F2"));
            Console.WriteLine("Payment: PHP " + order.Payment.ToString("F2"));
            Console.WriteLine("Change: PHP " + order.Change.ToString("F2"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Thank you for ordering!");
            Console.WriteLine("================================");

            Console.ReadKey();
        }
    }
}
