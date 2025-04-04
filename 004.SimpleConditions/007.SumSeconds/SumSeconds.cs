//Simple conditions, Task 007
//04.04.2025, 21:06
using System;

public class SumSeconds
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int seconds = first + second + third;

        int minutes = 0;

        if(seconds > 59)
        {
            minutes++;
            seconds -= 60;
        }

        if (seconds > 59)
        {
            minutes++;
            seconds -= 60;
        }

        if(seconds < 10)
        {
            Console.WriteLine(minutes + ":" + "0" + seconds);
        }
        else
        {
            Console.WriteLine(minutes + ":" + seconds);
        }
    }
}