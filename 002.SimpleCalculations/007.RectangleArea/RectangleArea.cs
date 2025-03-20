//Simple calculation, Task 007
//20.03.2025, 22:55
using System;

public class RectangleArea
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double a = Math.Abs(x1 - x2);
        double b = Math.Abs(y1 - y2);

        double area = a * b;
        double perimeter = 2 * (a + b);

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}