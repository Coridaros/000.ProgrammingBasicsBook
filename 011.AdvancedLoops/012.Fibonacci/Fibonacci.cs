//Advanced loops, Task 012
//22.04.2025, 21:41
using System;

public class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstF = 1;
        int secondF = 1;

        for(int i = 0; i < n - 1; i++)
        {
            int nextF = firstF + secondF;
            firstF = secondF;
            secondF = nextF;
        }

        Console.WriteLine(secondF);
    }
}