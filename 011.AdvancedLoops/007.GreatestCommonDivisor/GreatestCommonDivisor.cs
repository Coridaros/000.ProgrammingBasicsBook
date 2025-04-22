//Advanced loops, Task 007
//22.04.2025, 02:18
using System;

public class GreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while(b != 0)
        {
            var oldB = b;
            b = a % b;
            a = oldB;
        }

        Console.WriteLine($"GCD = {a}");
    }
}