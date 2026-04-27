using System;
class Baekjoon8714
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();

        int a = 0;
        int b = 0;

        for (int i = 0; i < n; i++)
        {
            if (input[i] == "0") a++;
            else b++;
        }

        Console.WriteLine(Math.Min(a, b));
    }
}