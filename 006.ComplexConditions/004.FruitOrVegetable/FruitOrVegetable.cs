//Complex conditions, Task 004
//06.04.2025, 19:33
using System;

public class FruitOrVegetable
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();

        if(product == "banana" || product == "apple" || product == "kiwi" || 
            product == "cherry" || product == "lemon" || product == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if(product == "tomato" || product == "cucumber" || product == "pepper" ||
            product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}