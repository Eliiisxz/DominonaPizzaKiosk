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

                Console.WriteLine("Product added to cart!");
            }
            else
            {
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
            Console.WriteLine("\n========== YOUR CART ==========");

            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine(
                    Items[i].Product.Name +
                    " x" + Items[i].Quantity +
                    " = PHP " + Items[i].GetSubtotal()
                );
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("TOTAL: PHP " + GetTotal());
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
