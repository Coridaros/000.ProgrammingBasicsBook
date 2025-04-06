//Simple conditions - exercise, Task 002
//06.04.2025, 14:20
using System;

public class PipesInPool
{
    static void Main()
    {
        int poolVolume = int.Parse(Console.ReadLine());
        int pipeOneDebit = int.Parse(Console.ReadLine());
        int pipeTwoDebit = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double water = (pipeOneDebit + pipeTwoDebit) * hours;

        if(water <= poolVolume)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate(water / poolVolume * 100),
                Math.Truncate(pipeOneDebit * hours / water * 100),
                Math.Truncate(pipeTwoDebit * hours / water * 100));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                hours, water - poolVolume);
        }
    }
}