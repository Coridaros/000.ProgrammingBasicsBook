//First steps in programming, Task 006
//19.03.2025, 23:46
using System;

public class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for(int i = 0; i < n - 2; i++)
        {
            Console.WriteLine('*' + new string(' ', n - 2) + '*');
        }

        Console.WriteLine(new string('*', n));
    }
}