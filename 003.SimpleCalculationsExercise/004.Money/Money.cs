//Simple calculations - exercise, Task 004
//02.04.2025, 22:14
using System;

public class Money
{
    static void Main()
    {
        int bitcoinsCnt = int.Parse(Console.ReadLine());
        double yoansCnt = double.Parse(Console.ReadLine());
        double comm = double.Parse(Console.ReadLine());

        double bitcoinsToLeva = bitcoinsCnt * 1168;
        double yoansToDollars = yoansCnt * 0.15;
        double dollarsToLeva = yoansToDollars * 1.76;
        double leva = bitcoinsToLeva + dollarsToLeva;
        double total = leva / 1.95;
        double commsion = total * (comm / 100.0);
        total -= commsion;

        Console.WriteLine(total);
    }
}