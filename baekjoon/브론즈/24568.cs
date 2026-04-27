using System;

class Program
{
    static void Main()
    {
        int R = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());

        int total = R * 8 + S * 3;
        int leftover = total - 28;

        Console.WriteLine(leftover);
    }
}