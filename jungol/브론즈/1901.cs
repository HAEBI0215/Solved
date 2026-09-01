using System;

class Program
{
    static void Main()
    {
        const int MAX = 1000000;

        bool[] isPrime = new bool[MAX + 1];

        for (int i = 2; i <= MAX; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= MAX; i++)
        {
            if (!isPrime[i])
                continue;

            for (int j = i * i; j <= MAX; j += i)
            {
                isPrime[j] = false;
            }
        }

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            if (isPrime[m])
            {
                Console.WriteLine(m);
                continue;
            }

            int distance = 1;

            while (true)
            {
                int left = m - distance;
                int right = m + distance;

                bool leftPrime = false;
                bool rightPrime = false;

                if (left >= 2)
                {
                    leftPrime = isPrime[left];
                }

                if (right <= MAX)
                {
                    rightPrime = isPrime[right];
                }

                if (leftPrime && rightPrime)
                {
                    Console.WriteLine($"{left} {right}");
                    break;
                }

                if (leftPrime)
                {
                    Console.WriteLine(left);
                    break;
                }

                if (rightPrime)
                {
                    Console.WriteLine(right);
                    break;
                }

                distance++;
            }
        }
    }
}