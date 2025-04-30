//Exam preparation part 1, Task 004
//30.04.2025, 22:58
using System;

public class PointInFigure
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool rectOne = x >= 2 && x <= 12 && y >= -3 && y <= 1;
        bool rectTwo = x >= 4 && x <= 10 && y >= -5 && y <= 3;

        if(rectOne || rectTwo)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}