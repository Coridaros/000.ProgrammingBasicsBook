﻿//Loops, Task 005
//12.04.2025, 16:05
using System;

public class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxNumber = int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine(maxNumber);
    }
}