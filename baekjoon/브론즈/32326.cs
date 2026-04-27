using System;

class Program
{
    static void Main()
    {
        int R = int.Parse(Console.ReadLine());
        int G = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int cost = R * 3 + G * 4 + B * 5;
        Console.WriteLine(cost);
    }
}