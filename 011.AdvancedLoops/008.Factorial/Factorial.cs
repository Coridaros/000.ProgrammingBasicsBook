//Advanced loops, Task 008
//22.04.2025, 02:21
using System;

public class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fact = 1;

        do
        {
            fact = fact * n;
            n--;
        }
        while (n > 1);

        Console.WriteLine(fact);
    }
}