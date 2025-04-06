//Complex conditions, Task 001
//06.04.2025, 18:31
using System;

public class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if(age < 16)
        {
            if(gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if(gender == "f")
            {
                Console.WriteLine("Miss");
            }
        }
        else if(age >= 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == "f")
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}