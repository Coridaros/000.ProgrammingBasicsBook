//Loops - exercise, Task 002
//12.04.2025, 23:37
using System;

public class SmartLilly
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        int toyCnt = 0;
        int mCnt = 0;
        double bdMoney = 0.0;
        double savedMoney = 0.0;

        for(int i = 1; i <= age; i++)
        {
            if(i % 2 == 0)
            {
                mCnt++;
                bdMoney += 10;
                savedMoney += bdMoney;
            }
            else
            {
                toyCnt++;
            }
        }

        double money = toyCnt * toyPrice + (savedMoney - mCnt);

        if(money >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {(money - washingMachinePrice):F2}");
        }
        else
        {
            Console.WriteLine($"No! {(washingMachinePrice - money):F2}");
        }
    }
}