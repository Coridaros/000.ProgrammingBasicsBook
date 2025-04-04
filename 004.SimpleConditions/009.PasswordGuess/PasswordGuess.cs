//Simple conditions, Task 009
//04.04.2025, 21:28
using System;

public class PasswordGuess
{
    static void Main()
    {
        string password = "s3cr3t!P@ssw0rd";
        string pass = Console.ReadLine();

        if(pass == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}