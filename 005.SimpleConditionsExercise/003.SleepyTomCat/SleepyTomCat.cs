//Simple conditions - exercise, Task 003
//06.04.2025, 15:08
using System;

public class SleepyTomCat
{
    static void Main()
    {
        int holyDays = int.Parse(Console.ReadLine());

        int workingDays = 365 - holyDays;
        int playTime = holyDays * 127 + workingDays * 63;
        int diff = Math.Abs(playTime - 30000);
        int hours = diff / 60;
        int minutes = diff % 60;

        if(playTime > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
    }
}