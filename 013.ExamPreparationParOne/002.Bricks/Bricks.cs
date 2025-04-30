//Exam preparation part 1, Task 002
//30.04.2025, 22:00
using System;

public class Bricks
{
    static void Main()
    {
        int bricksCnt = int.Parse(Console.ReadLine());
        int workersCnt = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        double courses = Math.Ceiling((double)bricksCnt / (workersCnt * capacity));

        Console.WriteLine(courses);
    }
}