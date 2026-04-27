using System;
class Baekjoon8393
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i <= n; i++)
        {
            result = n + i;
        }
        Console.WriteLine(result);
    }
}