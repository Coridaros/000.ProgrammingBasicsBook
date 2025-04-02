//Simple conditions, Task 004
//03.04.2025, 00:45
using System;

public class GreaterNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        if(firstNumber > secondNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else
        {
            Console.WriteLine(secondNumber);
        }
    }
}