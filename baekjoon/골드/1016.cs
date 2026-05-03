// 제곱 ㄴㄴ 수 

// 문제
// 어떤 정수 X가 1보다 큰 제곱수로 나누어 떨어지지 않을 때, 그 수를 제곱ㄴㄴ수라고 한다. 제곱수는 정수의 제곱이다. min과 max가 주어지면, min보다 크거나 같고, max보다 작거나 같은 제곱ㄴㄴ수가 몇 개 있는지 출력한다.

// 입력
// 첫째 줄에 두 정수 min과 max가 주어진다.

// 출력
// 첫째 줄에 min보다 크거나 같고, max보다 작거나 같은 제곱ㄴㄴ수의 개수를 출력한다.

// 제한
// 1 ≤ min ≤ 1,000,000,000,000
// min ≤ max ≤ min + 1,000,000

using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split();
        long min = long.Parse(parts[0]);
        long max = long.Parse(parts[1]);
        long len = max - min + 1;
        bool[] marked = new bool[len];

        for (long p = 2; p * p <= max; p++)
        {
            long sq = p * p;
            long start = (min + sq - 1) / sq * sq;
            for (long x = start; x <= max; x += sq)
            {
                marked[x - min] = true;
            }
        }

        int count = 0;
        for (long i = 0; i < len; i++)
        {
            if (!marked[i]) count++;
        }

        Console.WriteLine(count);
    }
}