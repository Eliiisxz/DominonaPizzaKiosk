
using System;

public class FormWelcome
{
    public static string ShowWelcome()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("========================================");
        Console.WriteLine("           DOMINONA PIZZA");
        Console.WriteLine("          SELF-SERVICE KIOSK");
        Console.WriteLine("========================================");

        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("       FRESH PIZZA, HAPPY MOMENTS!");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("          WELCOME!");
        Console.WriteLine();
        Console.WriteLine("       [1] CUSTOMER");
        Console.WriteLine("       [2] CASHIER");
        Console.WriteLine("       [3] EXIT");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------");

        Console.Write("       Select your option: ");

        return Console.ReadLine();
    }
}
