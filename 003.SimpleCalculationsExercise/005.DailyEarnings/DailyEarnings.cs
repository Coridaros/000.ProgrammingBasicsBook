//Simple calculations - exercise, Task 005
//02.04.2025, 23:41
using System;

public class DailyEarnings
{
    static void Main()
    {
        int workingDays = int.Parse(Console.ReadLine());
        double earnedMoneyPerDay = double.Parse(Console.ReadLine());
        double dollarCurr = double.Parse(Console.ReadLine());

        double monthSalary = workingDays * earnedMoneyPerDay;
        double yearSallary = monthSalary * 12 + monthSalary * 2.5;
        double vat = yearSallary * 0.25;
        double total = (yearSallary - vat) * dollarCurr;
        total /= 365;

        Console.WriteLine($"{total:F2}");
    }
}