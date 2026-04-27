using System;
class baekjoon6721
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            int a = Reverse(int.Parse(input[0]));
            int b = Reverse(int.Parse(input[1]));

            int sum = a + b;

            Console.WriteLine(Reverse(sum));
        }
    }

    static int Reverse(int m)
    {
        int result = 0;

        while (m > 0)
        {
            result = result * 10 + (m % 10);
            m /= 10;
        }

        return result;
    }
}