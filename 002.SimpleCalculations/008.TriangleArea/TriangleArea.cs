//Simple calculations, Task 008
//20.03.2025, 23:02
using System;

public class TriangleArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = a * h / 2;

        Console.WriteLine(area);
    }
}