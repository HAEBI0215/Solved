// 입력 : 10억 이하의 자연수 5개가 공백으로 구분되어 주어진다

// 출력 :
// 입력된 순서대로 한 줄에 한 개씩 소수이면 "prime number",
// 합성수이면 "composite number",
// 소수도 합성수도 아니라면 "number one"으로 출력


using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int[] value = new int[5];

        for (int i = 0; i < 5; i++)
        {
            value[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            int n = value[i];

            if (n == 1)
            {
                Console.WriteLine("number one");
                continue;
            }

            bool isPrime = true;

            for (int j = 2; j * j <= n; j++)
            {
                if (n % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("composite number");
            }
        }
    }
}