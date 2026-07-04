using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            switch (input[0])
            {
                case "1":
                    stack.Push(int.Parse(input[1]));
                    break;

                case "2":
                    sb.AppendLine(stack.Count > 0 ? stack.Pop().ToString() : "-1");
                    break;

                case "3":
                    sb.AppendLine(stack.Count.ToString());
                    break;

                case "4":
                    sb.AppendLine(stack.Count == 0 ? "1" : "0");
                    break;

                case "5":
                    sb.AppendLine(stack.Count > 0 ? stack.Peek().ToString() : "-1");
                    break;
            }
        }

        Console.Write(sb.ToString());
    }
}