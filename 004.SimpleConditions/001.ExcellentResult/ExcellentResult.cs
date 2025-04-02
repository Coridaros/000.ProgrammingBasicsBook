//Simple conditions, Task 001
//03.04.2025, 00:06
using System;

public class ExcellentResult
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if(grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}