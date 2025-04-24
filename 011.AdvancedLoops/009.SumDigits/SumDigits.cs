//Advanced loops, Task 009
//22.04.2025, 02:31
using System;

public class SumDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        do
        {
            sum = sum + (n % 10);
            n = n / 10;
        }
        while (n > 0);

        Console.WriteLine(sum);
    }
}