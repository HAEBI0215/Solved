using System;

class Program
{
    static void Main()
    {
        int total = 0;

        for (int i = 0; i < 4; i++)
        {
            total += int.Parse(Console.ReadLine());
        }

        total += 300;

        if (total <= 1800)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}