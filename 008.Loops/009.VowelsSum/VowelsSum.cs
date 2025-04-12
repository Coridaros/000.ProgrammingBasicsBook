//Loops, Task 009
//12.04.2025, 19:30
using System;

public class VowelsSum
{
    static void Main()
    {
        string msg = Console.ReadLine();

        int sum = 0;

        for(int i = 0; i < msg.Length; i++)
        {
            if (msg[i] == 'a')
            {
                sum += 1;
            }
            else if (msg[i] == 'e')
            {
                sum += 2;
            }
            else if (msg[i] == 'i')
            {
                sum += 3;
            }
            else if (msg[i] == 'o')
            {
                sum += 4;
            }
            else if (msg[i] == 'u')
            {
                sum += 5;
            }
        }

        Console.WriteLine(sum);
    }
}