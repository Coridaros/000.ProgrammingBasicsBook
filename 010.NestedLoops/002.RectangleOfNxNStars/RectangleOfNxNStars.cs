//Nested loops, Task 002
//22.04.2025, 01:17
using System;

public class RectangleOfNxNStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}