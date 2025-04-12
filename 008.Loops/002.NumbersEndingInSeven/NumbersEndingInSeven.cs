//Loops, Task 002
//12.04.2025, 13:58
using System;

public class NumbersEndingInSeven
{
    static void Main()
    {
        for(int i = 1; i <= 1000; i++)
        {
            if(i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}