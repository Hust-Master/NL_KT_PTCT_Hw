using System;

class DataflowExample
{
    static void Main()
    {
        int x = 0;  // Dòng 1
        int y = 5;  // Dòng 2

        if (y > 3)  // Dòng 3
        {
            x = y + 1; // Dòng 4
        }
        else
        {
            x = y - 1; // Dòng 5
        }

        Console.WriteLine(x); // Dòng 6
    }
}
