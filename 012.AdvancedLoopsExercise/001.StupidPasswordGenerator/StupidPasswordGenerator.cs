﻿//Advanced loops - exercise, Task 001
//23.04.2025, 00:09
using System;

public class StupidPasswordGenerator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for(int d1 = 1; d1 <= n; d1++)
        {
            for(int d2 = 1; d2 <= n; d2++)
            {
                for(char l1 = 'a'; l1 < 'a' + l; l1++)
                {
                    for(char l2 = 'a'; l2 < 'a' + l; l2++)
                    {
                        for(var d3 = Math.Max(d1, d2) + 1; d3 <= n; d3++)
                        {
                            Console.Write($"{d1}{d2}{l1}{l2}{d3} ");
                        }

                        //Console.WriteLine();
                    }
                }
            }
        }
    }
}