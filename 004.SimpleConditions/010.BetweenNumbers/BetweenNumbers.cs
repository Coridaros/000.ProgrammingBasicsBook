﻿//Simple conditions, Task 010
//04.04.2025, 21:46
using System;

public class BetweenNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if(number >= 100 && number <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else if(number > 200)
        {
            Console.WriteLine("Greater than 200");
        }
    }
}