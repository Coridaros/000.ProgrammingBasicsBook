//Simple conditions - exercise, Task 004
//06.04.2025, 16:17
using System;

public class Harvest
{
    static void Main()
    {
        int vineyardArea = int.Parse(Console.ReadLine());
        double grapes = double.Parse(Console.ReadLine());
        int neededVine = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double grapesKilograms = (vineyardArea * 0.40) * grapes;
        double vine = grapesKilograms / 2.5;

        if(vine < neededVine)
        {
            int nVine = (int)Math.Floor(neededVine - vine);
            Console.WriteLine($"It will be a tough winter! More {nVine} liters wine needed.");
        }
        else
        {
            int cVine = (int)Math.Floor(vine);
            double vineLeft = vine - neededVine;
            Console.WriteLine($"Good harvest this year! Total wine: {cVine} liters.");
            Console.WriteLine($"{(int)Math.Ceiling(vineLeft)} liters left -> {(int)Math.Ceiling(vineLeft / workers)} liters per person.");
        }
    }
}