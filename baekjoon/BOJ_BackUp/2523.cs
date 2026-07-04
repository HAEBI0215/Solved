using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));
        }

        for (int i = n - 1; i >= 1; i--)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}