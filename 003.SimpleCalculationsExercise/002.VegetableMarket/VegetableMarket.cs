//Simple calculation - exercise, Task 002
//02.04.2025, 21:43
using System;

public class VegetableMarket
{
    static void Main()
    {
        double vegatablesPrice = double.Parse(Console.ReadLine());
        double fruitsPrice = double.Parse(Console.ReadLine());
        int vegatablseWeight = int.Parse(Console.ReadLine());
        int fruitsWeight = int.Parse(Console.ReadLine());

        double total = (vegatablseWeight * vegatablesPrice + fruitsWeight * fruitsPrice) / 1.94;

        Console.WriteLine(total);
    }
}