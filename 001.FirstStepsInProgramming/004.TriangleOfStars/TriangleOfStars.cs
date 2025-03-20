//First steps in programming, Task 004
//19.03.2025, 23:38
using System;

public class TriangleOfStars
{
    static void Main()
    {
        for(int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}