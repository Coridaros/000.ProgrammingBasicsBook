//Loops, Task 007
//12.04.2025, 19:17
using System;

public class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int leftSum = 0;
        int rightSum = 0;

        for(int i = 0; i < n; i++)
        {
            leftSum += int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < n; i++)
        {
            rightSum += int.Parse(Console.ReadLine());
        }

        if(leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}