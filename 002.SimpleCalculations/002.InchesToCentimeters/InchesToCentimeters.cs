//Simple calculations, Task 002
//20.03.2025, 22:02
using System;

public class InchesToCentimeters
{
    static void Main()
    {
        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;

        Console.WriteLine(centimeters);
    }
}