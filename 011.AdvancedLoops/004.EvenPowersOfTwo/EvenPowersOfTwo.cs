//Advanced loops, Task 004
//22.04.2025, 01:49
using System;

public class EvenPowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int number = 1;

        for(int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(number);

            number = number * 2 * 2;
        }
    }
}