//Exam preparation part 1, Task 003
//30.04.2025, 22:09
using System;

public class PointOnSegment
{
    static void Main()
    {
        int startX = int.Parse(Console.ReadLine());
        int endX = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int left = Math.Min(startX, endX);
        int right = Math.Max(startX, endX);

        int distanceLeft = Math.Abs(left - x);
        int distanceRight = Math.Abs(right - x);

        int result = Math.Min(distanceLeft, distanceRight);

        if(x >= left && x <= right)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }

        Console.WriteLine(result);
    }
}