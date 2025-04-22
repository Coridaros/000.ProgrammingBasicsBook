//Advanced loops, Task 005
//22.04.2025, 01:57
using System;

public class SequenceTwoKPlusOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int number = 1;

        while(number <= n)
        {
            Console.WriteLine(number);

            number = 2 * number + 1;
        }
    }
}