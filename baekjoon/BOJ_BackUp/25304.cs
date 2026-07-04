using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            sum += a * b;
        }

        Console.WriteLine(sum == x ? "Yes" : "No");
    }
}