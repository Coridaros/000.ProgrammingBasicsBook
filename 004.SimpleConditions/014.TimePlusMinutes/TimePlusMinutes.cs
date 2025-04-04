//Simple conditions, Task 014
//04.04.2025, 22:19
using System;

public class TimePlusMinutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;

        if(minutes > 59)
        {
            hours++;
            minutes -= 60;
        }

        if(hours > 23)
        {
            hours -= 24;
        }

        if(minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine(hours + ":" + minutes);
        }
    }
}