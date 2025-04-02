//Simple conditions, Task 003
//03.04.2025, 00:22
using System;

public class EvenOrOdd
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}