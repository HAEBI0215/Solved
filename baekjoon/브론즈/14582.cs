using System;
class Baekjoon14582
{
    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int aScore = 0;
        int bScore = 0;

        for (int i = 0; i < 9; i++)
        {
            aScore += a[i];

            if (aScore > bScore)
            {
                Console.WriteLine("Yes");
                return;
            }

            bScore += b[i];
        }

        Console.WriteLine("No");
    }
}