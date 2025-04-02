//Simple conditions, Task 002
//03.04.2025, 00:16
using System;

public class ExcellentOrNot
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if(grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}