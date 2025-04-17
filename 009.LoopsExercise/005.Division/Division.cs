//Loops - exercise, Task 005
//17.04.2025, 22:39
using System;

public class Division
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        int divByTwoCnt = 0;
        int divByThreeCnt = 0;
        int divByFourCnt = 0;
        double divByTwoPercent = 0.0;
        double divByThreePercent = 0.0;
        double divByFourPercent = 0.0;

        for(int i = 0; i < numbers; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                divByTwoCnt++;
            }
            if(num % 3 == 0)
            {
                divByThreeCnt++;
            }
            if(num % 4 == 0)
            {
                divByFourCnt++;
            }
        }

        divByTwoPercent = divByTwoCnt / (numbers * 1.0) * 100;
        divByThreePercent = divByThreeCnt / (numbers * 1.0) * 100;
        divByFourPercent = divByFourCnt / (numbers * 1.0) * 100;

        Console.WriteLine($"{divByTwoPercent:F2}%");
        Console.WriteLine($"{divByThreePercent:F2}%");
        Console.WriteLine($"{divByFourPercent:F2}%");
    }
}