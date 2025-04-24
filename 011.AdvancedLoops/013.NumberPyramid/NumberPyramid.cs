//Advanced loops, Task 013
//22.04.2025, 21:46
using System;

public class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = 1;

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(j > 1)
                {
                    Console.Write(" ");
                }

                Console.Write(num);

                num++;

                if(num > n)
                {
                    break;
                }
            }

            Console.WriteLine();

            if(num > n)
            {
                break;
            }
        }
    }
}