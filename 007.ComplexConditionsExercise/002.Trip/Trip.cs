//Complex conditions - exercise, Task 002
//10.04.2025, 21:35
using System;

public class Trip
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        string typeTrip = string.Empty;
        string place = string.Empty;
        double spend = 0.0;

        if(budjet <= 100)
        {
            place = "Bulgaria";

            if(season == "summer")
            {
                typeTrip = "Camp";
                spend = budjet * 0.30;
            }
            else if(season == "winter")
            {
                typeTrip = "Hotel";
                spend = budjet * 0.70;
            }
        }
        else if(budjet > 100 && budjet <= 1000)
        {
            place = "Balkans";

            if (season == "summer")
            {
                typeTrip = "Camp";
                spend = budjet * 0.40;
            }
            else if (season == "winter")
            {
                typeTrip = "Hotel";
                spend = budjet * 0.80;
            }
        }
        else if(budjet > 1000)
        {
            place = "Europe";

            typeTrip = "Hotel";
            spend = budjet * 0.90;
        }

        if(budjet > 0)
        {
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{typeTrip} - {spend:F2}");
        }
    }
}