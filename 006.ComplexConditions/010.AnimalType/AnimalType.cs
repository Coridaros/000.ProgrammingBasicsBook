//Complex conditions, Task 010
//07.04.2025, 00:01
using System;

public class AnimalType
{
    static void Main()
    {
        string animal = Console.ReadLine();

        switch(animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}