﻿//Complex conditions, Task 005
//06.04.2025, 19:39
using System;

public class InvalidNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool inRange = (number >= 100 && number <= 200) || number == 0;

        if(!inRange)
        {
            Console.WriteLine("invalid");
        }
    }
}