//Simple conditions, Task 013
//04.04.2025, 22:10
using System;

public class AreaOfFigures
{
    static void Main()
    {
        string figure = Console.ReadLine().ToLower();

        if(figure == "square")
        {
            double a = double.Parse(Console.ReadLine());

            double area = a * a;

            Console.WriteLine($"{area:F3}");
        }
        else if(figure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;

            Console.WriteLine($"{area:F3}");
        }
        else if(figure == "circle")
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine($"{area:F3}");
        }
        else if(figure == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;

            Console.WriteLine($"{area:F3}");
        }
    }
}