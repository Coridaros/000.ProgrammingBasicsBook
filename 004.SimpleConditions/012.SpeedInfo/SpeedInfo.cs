﻿//Simple conditions, Task 012
//04.04.2025, 21:54
using System;

public class SpeedInfo
{
    static void Main()
    {
        double speed = double.Parse(Console.ReadLine());

        if(speed <= 10)
        {
            Console.WriteLine("slow");
        }
        else if(speed > 10 && speed <= 50)
        {
            Console.WriteLine("average");
        }
        else if(speed > 50 && speed <= 150)
        {
            Console.WriteLine("fast");
        }
        else if(speed > 150 && speed <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else if(speed > 1000)
        {
            Console.WriteLine("extremely fast");
        }
    }
}