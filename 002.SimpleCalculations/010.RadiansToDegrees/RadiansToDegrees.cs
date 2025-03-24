//Simple calculations, Task 010
//20.03.2025, 23:15
using System;

public class RadiansToDegrees
{
    static void Main()
    {
        double radians = double.Parse(Console.ReadLine());

        double degrees = radians * 180 / Math.PI;

        Console.WriteLine(Math.Round(degrees));
    }
}