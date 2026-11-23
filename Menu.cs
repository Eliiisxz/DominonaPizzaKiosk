using System;

namespace DominonaPizzaKiosk
{
    public class Menu
    {
        
public static Product[] Products =
{
    // PIZZA
    new Product("Peperoni Pizza", "Pizza", 299),
    new Product("Hawayan Pizza", "Pizza", 279),
    new Product("Chizzy Pizza", "Pizza", 249),
    new Product("Meat Luvr Pizza", "Pizza", 329),
    new Product("Vegi Delight Pizza", "Pizza", 259),
    new Product("Cheesy Overload", "Pizza", 349),

    // PASTA
    new Product("Karbonara", "Pasta", 159),
    new Product("Spagety", "Pasta", 139),
    new Product("Makaronni", "Pasta", 149),
    new Product("Cheezy Pasta", "Pasta", 169),
    new Product("Creamy Mushrum Pasta", "Pasta", 179),
    new Product("Spicy Pasta", "Pasta", 159),

    // CHICKEN
    new Product("Fryd Chiken", "Chicken", 99),
    new Product("Chiken Wengs", "Chicken", 129),
    new Product("Chiken Nuggits", "Chicken", 89),
    new Product("Spicy Chiken", "Chicken", 109),
    new Product("BBQ Chiken", "Chicken", 119),
    new Product("Crispy Chiken Pops", "Chicken", 99),

    // SIDES
    new Product("Frensh Frays", "Sides", 79),
    new Product("Mozarela Stiks", "Sides", 99),
    new Product("Onion Rengs", "Sides", 89),
    new Product("Potato Wedgies", "Sides", 89),
    new Product("Cheezy Balls", "Sides", 99),
    new Product("Nachos", "Sides", 109),

    // DRINKS
    new Product("Kola", "Drinks", 45),
    new Product("Ays Ti", "Drinks", 40),
    new Product("Limonayd", "Drinks", 50),
    new Product("Oranj Juis", "Drinks", 55),
    new Product("Choklet Sheyk", "Drinks", 79),
    new Product("Straberi Sheyk", "Drinks", 79),

    // DESSERTS
    new Product("Choklet Kake", "Desserts", 89),
    new Product("Browni", "Desserts", 69),
    new Product("Donat", "Desserts", 49),
    new Product("Kuki", "Desserts", 39),
    new Product("Ays Krim", "Desserts", 59),
    new Product("Chiz Kake", "Desserts", 99)
};

        public static void ShowMenu(Cart cart)
        {
            string orderType = "";

            // ORDER TYPE
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("========================================");
                Console.WriteLine("          DOMINONA PIZZA KIOSK");
                Console.WriteLine("========================================");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n              ORDER TYPE");

                Console.WriteLine("\n[1] DINE IN");
                Console.WriteLine("[2] TAKE OUT");
                Console.WriteLine("[0] BACK TO MAIN MENU");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nSelect order type: ");

                int typeChoice;

                if (!int.TryParse(Console.ReadLine(), out typeChoice))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                    continue;
                }

                if (typeChoice == 1)
                {
                    orderType = "Dine In";
                    break;
                }
                else if (typeChoice == 2)
                {
                    orderType = "Take Out";
                    break;
                }
                else if (typeChoice == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                    Console.ReadKey();
                }
            }

            string[] categories =
            {
                "Pizza", "Pasta", "Chicken",
                "Sides", "Drinks", "Desserts"
            };

            // CATEGORY MENU
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("========================================");
                Console.WriteLine("          DOMINONA PIZZA KIOSK");
                Console.WriteLine("========================================");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n             FOOD CATEGORIES");

                for (int i = 0; i < categories.Length; i++)
                {
                    Console.WriteLine(
                        "[" + (i + 1) + "] " + categories[i]
                    );
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nOrder Type: " + orderType);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[0] CHECKOUT");
                Console.WriteLine("[99] BACK TO MAIN MENU");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nSelect category: ");

                int categoryChoice;

                if (!int.TryParse(Console.ReadLine(), out categoryChoice))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                    continue;
                }

                if (categoryChoice == 99)
                {
                    return;
                }

                if (categoryChoice == 0)
                {
                    if (Checkout.Process(cart, orderType))
                    {
                        return;
                    }

                    continue;
                }

                if (categoryChoice < 1 ||
                    categoryChoice > categories.Length)
                {
                    Console.WriteLine("Invalid category!");
                    Console.ReadKey();
                    continue;
                }

                string selectedCategory =
                    categories[categoryChoice - 1];

                // PRODUCTS INSIDE SELECTED CATEGORY
                while (true)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("========================================");
                    Console.WriteLine("          DOMINONA PIZZA KIOSK");
                    Console.WriteLine("========================================");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n              " + selectedCategory.ToUpper());

                    int productNumber = 0;

                    for (int i = 0; i < Products.Length; i++)
                    {
                        if (Products[i].Category == selectedCategory)
                        {
                            productNumber++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(
                                "[" + productNumber + "] " +
                                Products[i].Name +
                                " - PHP " + Products[i].Price
                            );
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n[0] BACK TO CATEGORIES");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nSelect product: ");

                    int productChoice;

                    if (!int.TryParse(Console.ReadLine(), out productChoice))
                    {
                        Console.WriteLine("Invalid input!");
                        Console.ReadKey();
                        continue;
                    }

                    if (productChoice == 0)
                    {
                        break;
                    }

                    if (productChoice < 1 ||
                        productChoice > productNumber)
                    {
                        Console.WriteLine("Invalid product!");
                        Console.ReadKey();
                        continue;
                    }

                    int selectedIndex = -1;
                    int count = 0;

                    for (int i = 0; i < Products.Length; i++)
                    {
                        if (Products[i].Category == selectedCategory)
                        {
                            count++;

                            if (count == productChoice)
                            {
                                selectedIndex = i;
                                break;
                            }
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter quantity: ");

                    int quantity;

                    if (!int.TryParse(Console.ReadLine(), out quantity)
                        || quantity <= 0)
                    {
                        Console.WriteLine("Invalid quantity!");
                        Console.ReadKey();
                        continue;
                    }

                    cart.AddProduct(Products[selectedIndex], quantity);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nProduct added successfully!");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
