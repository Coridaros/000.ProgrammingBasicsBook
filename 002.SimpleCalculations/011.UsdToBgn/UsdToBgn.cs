//Simple calculation, Task 011
//20.03.2025, 23:35
using System;

public class UsdToBgn
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());

        double bgn = usd * 1.79549;

        Console.WriteLine($"{bgn:F2} BGN");
    }
}