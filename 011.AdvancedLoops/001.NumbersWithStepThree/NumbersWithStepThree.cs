//Advanced loops, Task 001
//22.04.2025, 01:37
using System;

public class NumbersWithStepThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}