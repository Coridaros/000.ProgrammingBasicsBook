//Complex conditions - exercise, Task 004
//10.04.2025, 22:57
using System;

public class MatchTickets
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int peopleCnt = int.Parse(Console.ReadLine());

        double transportPrice = 0.0;
        double ticketPrice = 0.0;

        if(peopleCnt >= 1 && peopleCnt <= 4)
        {
            transportPrice = budjet * 0.75;
        }
        else if(peopleCnt >= 5 && peopleCnt <= 9)
        {
            transportPrice = budjet * 0.60;
        }
        else if(peopleCnt >= 10 && peopleCnt <= 24)
        {
            transportPrice = budjet * 0.50;
        }
        else if(peopleCnt >= 25 && peopleCnt <= 49)
        {
            transportPrice = budjet * 0.40;
        }
        else if(peopleCnt >= 50)
        {
            transportPrice = budjet * 0.25;
        }

        switch(category)
        {
            case "Normal":
                {
                    ticketPrice = peopleCnt * 249.99;
                }
                break;
            case "VIP":
                {
                    ticketPrice = peopleCnt * 499.99;
                }
                break;
            default:
                ticketPrice = peopleCnt * 249.99;
                break;
        }

        double moneyDiff = budjet - transportPrice - ticketPrice;

        if(moneyDiff < 0)
        {
            Console.WriteLine($"Not enough money! You need {(Math.Abs(moneyDiff)):F2} leva.");
        }
        else
        {
            Console.WriteLine($"Yes! You have {moneyDiff:F2} leva left.");
        }
    }
}