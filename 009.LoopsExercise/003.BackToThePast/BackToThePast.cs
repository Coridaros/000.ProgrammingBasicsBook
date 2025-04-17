//Loops - exercise, Task 003
//17.04.2025, 21:58
using System;

public class BackToThePast
{
    static void Main()
    {
        double legacy = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int years = 18;

        double spendMoney = 0.0;

        for(int i = 1800; i <= year; i++)
        {
            if(i % 2 == 0)
            {
                legacy -= 12000;
            }
            else
            {
                legacy -= (12000 + 50 * years);
            }

            years++;
        }

        if(legacy >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {legacy:F2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {Math.Abs(legacy):F2} dollars to survive.");
        }
    }
}