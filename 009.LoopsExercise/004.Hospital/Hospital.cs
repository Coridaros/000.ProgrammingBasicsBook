//Loops - exercise, Task 004
//17.04.2025, 22:24
using System;

public class Hospital
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int doctorsCnt = 7;

        for(int i = 1; i <= period; i++)
        {
            int currentPatients = int.Parse(Console.ReadLine());

            if((i % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                doctorsCnt++;
            }

            if(currentPatients > doctorsCnt)
            {
                treatedPatients += doctorsCnt;
                untreatedPatients += currentPatients - doctorsCnt;
            }
            else
            {
                treatedPatients += currentPatients;
            }
        }

        Console.WriteLine($"Treated patients: {treatedPatients}.");
        Console.WriteLine($"Untreated patients: {untreatedPatients}.");
    }
}