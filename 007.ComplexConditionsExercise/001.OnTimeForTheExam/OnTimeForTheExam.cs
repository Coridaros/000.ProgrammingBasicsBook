//Complex conditions - exercise, Task 001
//10.04.2025, 00:26
using System;

public class OnTimeForTheExam
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());

        string late = "Late";
        string onTime = "On time";
        string early = "Early";

        int examTime = (examHour * 60) + examMinutes;
        int arrivalTime = (arrivalHour * 60) + arrivalMinutes;
        int totalMinutesDiff = arrivalTime - examTime;

        string studentArrival = late;

        if(totalMinutesDiff < -30)
        {
            studentArrival = early;
        }
        else if(totalMinutesDiff <= 30)
        {
            studentArrival = onTime;
        }

        string result = string.Empty;

        if(totalMinutesDiff != 0)
        {
            int hoursDiff = Math.Abs(totalMinutesDiff / 60);
            int minutesDiff = Math.Abs(totalMinutesDiff % 60);

            if(hoursDiff > 0)
            {
                result = string.Format("{0}:{1:00} hours", hoursDiff, minutesDiff);
            }
            else
            {
                result = minutesDiff + " minutes";
            }

            if(totalMinutesDiff < 0)
            {
                result += " before start";
            }
            else
            {
                result += " after start";
            }
        }

        Console.WriteLine(studentArrival);

        if(!string.IsNullOrEmpty(result))
        {
            Console.WriteLine(result);
        }
    }
}