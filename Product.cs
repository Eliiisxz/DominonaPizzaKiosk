
using System;


namespace DominonaPizzaKiosk
{
    public class Product
    {
        public string Name;
        public string Category;
        public double Price;

        public Product(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
