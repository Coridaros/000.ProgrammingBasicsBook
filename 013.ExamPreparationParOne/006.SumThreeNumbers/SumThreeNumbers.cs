//Exam preparation part 1, Task 006
//02.05.2025, 15:24
using System;

public class SumThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if(a + b == c)
        {
            if(a > b)
            {
                Console.WriteLine($"{b} + {a} = {c}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} = {c}");
            }
        }
        else if(a + c == b)
        {
            if(a < c)
            {
                Console.WriteLine($"{a} + {c} = {b}");
            }
            else
            {
                Console.WriteLine($"{c} + {a} = {b}");
            }
        }
        else if(b + c == a)
        {
            if(b < c)
            {
                Console.WriteLine($"{b} + {c} = a");
            }
            else
            {
                Console.WriteLine($"{c} + {b} = a");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}