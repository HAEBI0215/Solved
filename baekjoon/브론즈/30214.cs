using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int s1 = int.Parse(input[0]);
        int s2 = int.Parse(input[1]);

        if (s1 * 2 >= s2)
            Console.WriteLine("E");
        else
            Console.WriteLine("H");
    }
}