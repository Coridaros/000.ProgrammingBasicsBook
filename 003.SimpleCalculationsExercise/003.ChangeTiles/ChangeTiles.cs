//Simple calculations - exercise, Task 003
//02.04.2025, 22:04
using System;

public class ChangeTiles
{
    static void Main()
    {
        int areaSide = int.Parse(Console.ReadLine());
        double tileW = double.Parse(Console.ReadLine());
        double tileL = double.Parse(Console.ReadLine());
        double benchW = double.Parse(Console.ReadLine());
        double benchL = double.Parse(Console.ReadLine());

        int area = areaSide * areaSide;
        double tileArea = tileW * tileL;
        double benchArea = benchW * benchL;

        double nArea = area - benchArea;
        double nTiles = nArea / tileArea;
        double nTime = nTiles * 0.2;

        Console.WriteLine(nTiles);
        Console.WriteLine(nTime);
    }
}