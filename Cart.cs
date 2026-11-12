using System;

namespace DominonaPizzaKiosk
{
    public class Cart
    {
        public CartItem[] Items = new CartItem[50];
        public int ItemCount = 0;

        public void AddProduct(Product product, int quantity)
        {
            if (ItemCount < Items.Length)
            {
                Items[ItemCount] = new CartItem(product, quantity);
                ItemCount++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product added to cart!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cart is full!");
            }
        }

        public double GetTotal()
        {
            double total = 0;

            for (int i = 0; i < ItemCount; i++)
            {
                total += Items[i].GetSubtotal();
            }

            return total;
        }

        public void DisplayCart()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("          DOMINONA PIZZA KIOSK");
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                YOUR CART");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < ItemCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Items[i].Product.Name);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Quantity: " + Items[i].Quantity);
                Console.WriteLine(
                    "Subtotal: PHP " +
                    Items[i].GetSubtotal().ToString("F2")
                );
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "TOTAL: PHP " + GetTotal().ToString("F2")
            );

            Console.ResetColor();
        }

        public CartItem[] GetItemsCopy()
        {
            CartItem[] copy = new CartItem[ItemCount];

            for (int i = 0; i < ItemCount; i++)
            {
                copy[i] = Items[i];
            }

            return copy;
        }

        public void ClearCart()
        {
            ItemCount = 0;
        }
    }
}
