//Simple conditions - exercise, Task 005
//06.04.2025, 16:51
using System;

public class Firm
{
    static void Main()
    {
        int projectHours = int.Parse(Console.ReadLine());
        int availableDays = int.Parse(Console.ReadLine());
        int overtimeWorkers = int.Parse(Console.ReadLine());

        double workingDays = availableDays * 0.90;
        double overtime = (overtimeWorkers * 2) * availableDays;
        int workHours = (int)Math.Floor(workingDays * 8 + overtime);

        if(projectHours <= workHours)
        {
            Console.WriteLine($"Yes!{workHours - projectHours} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{projectHours - workHours} hours needed.");
        }
    }
}