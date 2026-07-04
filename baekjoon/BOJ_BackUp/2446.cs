using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }

        for (int i = 2; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}