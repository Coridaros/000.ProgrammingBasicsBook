//Simple conditions - exercise, Task 001
//06.04.2025, 14:09
using System;

public class TransportPrice
{
    static void Main()
    {
        int kilometers = int.Parse(Console.ReadLine());
        string time = Console.ReadLine().ToLower();

        double price = 0.00;
        double taxiRate = 0.00;

        if(time == "day")
        {
            taxiRate = 0.79;
        }
        else if(time == "night")
        {
            taxiRate = 0.90;
        }

        if(kilometers < 20)
        {
            price = kilometers * taxiRate + 0.70;
        }
        else if(kilometers >= 20 && kilometers < 100)
        {
            price = kilometers * 0.09;
        }
        else if(kilometers >= 100)
        {
            price = kilometers * 0.06;
        }

        Console.WriteLine(price);
    }
}