//Loops, Task 004
//12.04.2025, 14:30
using System;

public class SumNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}