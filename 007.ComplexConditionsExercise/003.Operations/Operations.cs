//Complex conditions - exercise, Task 003
//10.04.2025, 22:12
using System;

public class Operations
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        string sign = Console.ReadLine();
        decimal result = 0.00M;
        string output = string.Empty;

        if(secondNumber == 0 && (sign == "/" || sign == "%"))
        {
            output = "Cannot divide " + firstNumber + " by zero";
        }
        else if(sign == "/")
        {
            result = firstNumber / secondNumber;
            output = string.Format($"{firstNumber} {sign} {secondNumber} = {result:F2}");
        }
        else if(sign == "%")
        {
            result = firstNumber % secondNumber;
            output = string.Format($"{firstNumber} {sign} {secondNumber} = {result}");
        }
        else
        {
            if(sign == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if(sign == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if(sign == "*")
            {
                result = firstNumber * secondNumber;
            }

            output = string.Format($"{firstNumber} {sign} {secondNumber} = {result} - " +
                $"{(result % 2 == 0 ? "even" : "odd")}");
        }

        Console.WriteLine(output);
    }
}