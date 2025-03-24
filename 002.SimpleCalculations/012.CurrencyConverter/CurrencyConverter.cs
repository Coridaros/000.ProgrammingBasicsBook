//Simple calculations, Task 012
//20.03.2025, 23:31
using System;

public class CurrencyConverter
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        string currency = Console.ReadLine().ToUpper();
        string wantedcurrecy = Console.ReadLine().ToUpper();

        if(currency == "BGN")
        {
            if(wantedcurrecy == "EUR")
            {
                amount /= 1.95583;

                Console.WriteLine($"{amount:F2} {wantedcurrecy}");
            }
            else if(wantedcurrecy == "GBP")
            {
                amount /= 2.53405;
                Console.WriteLine($"{amount:F2} {wantedcurrecy}");
            }
            else if(wantedcurrecy == "USD")
            {
                amount /= 1.79549;
                Console.WriteLine($"{amount:F2} {wantedcurrecy}");
            }
        }
        else if(currency == "EUR")
        {
            double leva = amount * 1.95583;

            if(wantedcurrecy == "BGN")
            {
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
            else if(wantedcurrecy == "GBP")
            {
                leva /= 2.53405;
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
            else if(wantedcurrecy == "USD")
            {
                leva /= 1.79549;
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
        }
        else if(currency == "GBP")
        {
            double leva = amount * 2.53405;

            if(wantedcurrecy == "BGN")
            {
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
            else if(wantedcurrecy == "EUR")
            {
                leva /= 1.95583;
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
            else if(wantedcurrecy == "USD")
            {
                leva /= 1.79549;
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
        }
        else if(currency == "USD")
        {
            double leva = amount * 1.79549;

            if (wantedcurrecy == "BGN")
            {
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
            else if (wantedcurrecy == "EUR")
            {
                leva /= 1.95583;
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
            else if (wantedcurrecy == "GBP")
            {
                leva /= 2.53405;
                Console.WriteLine($"{leva:F2} {wantedcurrecy}");
            }
        }
    }
}