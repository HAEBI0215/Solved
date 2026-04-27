using System;
class Baekjoon11213
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] count = new int[7];

        for (int i = 0; i < n; i++)
            count[a[i]]++;

        int max = -1;
        int index = -1;

        for (int i = 0; i < n; i++)
        {
            if (count[a[i]] == 1 && a[i] > max)
            {
                max = a[i];
                index = i + 1;
            }
        }

        if (index == -1)
            Console.WriteLine("None");
        else
            Console.WriteLine(index);
    }
}