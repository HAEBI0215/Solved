using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        Console.WriteLine($"{b - a} {b}");
    }
}