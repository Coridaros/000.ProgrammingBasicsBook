//Advanced loops, Task 002
//22.04.2025, 01:40
using System;

public class NumbersNToOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}