using System;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[2];

            input[0] = Console.ReadLine();
            input[1] = Console.ReadLine();

            Console.WriteLine(int.Parse(input[0]) * int.Parse(input[1]));

        }

    }
}