//Simple calculations, Task 009
//20.03.2025, 23:05
using System;

public class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(fahrenheit);
    }
}