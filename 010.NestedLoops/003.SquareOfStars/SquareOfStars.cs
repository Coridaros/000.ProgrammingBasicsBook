//Nested loops, Task 003
//22.04.2025, 01:20
using System;

public class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.Write("*");

            for(int j = 0; j < n; j++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}