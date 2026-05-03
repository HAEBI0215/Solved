// 피보나치 수의 합

// 문제
// 제 1항과 제 2항을 1이라 하고, 제 3항부터는 앞의 두 항의 합을 취하는 수열을 피보나치(fibonacci) 수열이라고 한다. 예를 들어 제 3항은 2이며, 제 4항은 3이다.

// 피보나치 수열의 a번째 항부터 b번째 항까지의 합을 구하는 프로그램을 작성하시오. 수가 매우 커질 수 있으므로 마지막 아홉 자리만을 구하도록 한다. 즉 1,000,000,000으로 나눈 나머지를 구하면 된다.

// 입력
// 첫째 줄에 a와 b이 주어진다.

using System;
using System.Numerics;

class Program
{
    const long MOD = 1000000000;

    static (long, long) Fib(long n)
    {
        if (n == 0) return (0, 1);
        var (a, b) = Fib(n >> 1);
        long c = (a * ((2 * b % MOD - a + MOD) % MOD)) % MOD;
        long d = ((a * a % MOD) + (b * b % MOD)) % MOD;
        if ((n & 1) == 0) return (c, d);
        return (d, (c + d) % MOD);
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        long Fb2 = Fib(b + 2).Item1 % MOD;
        long Fa1 = Fib(a + 1).Item1 % MOD;

        long ans = (Fb2 - Fa1) % MOD;
        if (ans < 0) ans += MOD;

        Console.WriteLine(ans);
    }
}