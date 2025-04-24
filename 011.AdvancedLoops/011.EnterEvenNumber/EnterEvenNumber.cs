//Advanced looops, Task 011
//22.04.2025, 21:30
using System;

public class EnterEvenNumber
{
    static void Main()
    {
        while(true)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                if(n % 2 == 0)
                {
                    Console.WriteLine(n);
                    break;
                }

                Console.WriteLine("The number is not even.");
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
        }


    }
}