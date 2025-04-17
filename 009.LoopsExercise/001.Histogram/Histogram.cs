//Loops - exercise, Task 001
//12.04.2025, 22:42
using System;

public class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int cntP1 = 0;
        int cntP2 = 0;
        int cntP3 = 0;
        int cntP4 = 0;
        int cntP5 = 0;
        double p1Percent = 0.0;
        double p2Percent = 0.0;
        double p3Percent = 0.0;
        double p4Percent = 0.0;
        double p5Percent = 0.0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < 200)
            {
                cntP1++;
            }
            else if(number >= 200 && number < 400)
            {
                cntP2++;
            }
            else if(number >= 400 && number < 600)
            {
                cntP3++;
            }
            else if(number >= 600 && number < 800)
            {
                cntP4++;
            }
            else if(number >= 800)
            {
                cntP5++;
            }
        }

        p1Percent = cntP1 / (n * 1.0) * 100.0;
        p2Percent = cntP2 / (n * 1.0) * 100.0;
        p3Percent = cntP3 / (n * 1.0) * 100.0;
        p4Percent = cntP4 / (n * 1.0) * 100.0;
        p5Percent = cntP5 / (n * 1.0) * 100.0;

        Console.WriteLine($"{p1Percent:F2}%");
        Console.WriteLine($"{p2Percent:F2}%");
        Console.WriteLine($"{p3Percent:F2}%");
        Console.WriteLine($"{p4Percent:F2}%");
        Console.WriteLine($"{p5Percent:F2}%");
    }
}