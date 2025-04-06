//Complex conditions, Task 007
//06.04.2025, 20:37
using System;

public class FruitShop
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        if(day == "saturday" || day == "sunday")
        {
            if(product == "banana")
            {
                double price = quantity * 2.70;
                Console.WriteLine($"{price:F2}");
            }
            else if(product == "apple")
            {
                double price = quantity * 1.25;
                Console.WriteLine($"{price:F2}");
            }
            else if(product == "orange")
            {
                double price = quantity * 0.90;
                Console.WriteLine($"{price:F2}");
            }
            else if(product == "grapefruit")
            {
                double price = quantity * 1.60;
                Console.WriteLine($"{price:F2}");
            }
            else if(product == "kiwi")
            {
                double price = quantity * 3.00;
                Console.WriteLine($"{price:F2}");
            }
            else if(product == "pineapple")
            {
                double price = quantity * 5.60;
                Console.WriteLine($"{price:F2}");
            }
            else if(product == "grapes")
            {
                double price = quantity * 4.20;
                Console.WriteLine($"{price:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if(day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
        {
            if (product == "banana")
            {
                double price = quantity * 2.50;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "apple")
            {
                double price = quantity * 1.20;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "orange")
            {
                double price = quantity * 0.85;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "grapefruit")
            {
                double price = quantity * 1.45;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "kiwi")
            {
                double price = quantity * 2.70;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "pineapple")
            {
                double price = quantity * 5.50;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "grapes")
            {
                double price = quantity * 3.85;
                Console.WriteLine($"{price:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}