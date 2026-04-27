using System;
class Baekjoon14007
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int count = 0;

        for (int i = 0; i < N; i++)
        {
            count++;

            int prev = 0;

            for (int j = i + 1; j < N; j++)
            {
                int cur = 0;

                if (arr[j] > arr[j - 1]) 
                    cur = 1;
                else if 
                    (arr[j] < arr[j - 1]) cur = -1;
                else 
                    break;

                if (prev == 0)
                {
                    prev = cur;
                    count++;
                }
                else
                {
                    if (cur == prev) 
                        break;
                    prev = cur;
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}