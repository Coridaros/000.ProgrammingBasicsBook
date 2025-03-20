//Simple calculations, Task 005
//20.03.2025, 22:23
using System;

public class TrapeziodArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2.0;

        Console.WriteLine($"Trapeziod area = {area}");
    }
}