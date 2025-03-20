//Simple calculations, Task 005
//20.03.2025
using System;

public class CircleAreaAndPerimeter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}