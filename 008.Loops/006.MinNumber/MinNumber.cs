//Loops, Task 006
//12.04.2025, 16:21
using System;

public class MinNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int minNumber = int.MaxValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < minNumber)
            {
                minNumber = number;
            }
        }

        Console.WriteLine(minNumber);
    }
}