using System;
using System.Text;
class baekjoon10845
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<int> queue = new Queue<int>();
        StringBuilder sb = new StringBuilder();
        
        int lastValue = -1;

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();

            switch (command[0])
            {
                case "push":
                    lastValue = int.Parse(command[1]);
                    queue.Enqueue(lastValue);
                    break;

                case "pop":
                    if (queue.Count == 0) sb.AppendLine("-1");
                    else sb.AppendLine(queue.Dequeue().ToString());
                    break;

                case "size":
                    sb.AppendLine(queue.Count.ToString());
                    break;

                case "empty":
                    sb.AppendLine(queue.Count == 0 ? "1" : "0");
                    break;

                case "front":
                    if (queue.Count == 0) sb.AppendLine("-1");
                    else sb.AppendLine(queue.Peek().ToString());
                    break;

                case "back":
                    if (queue.Count == 0) sb.AppendLine("-1");
                    else sb.AppendLine(lastValue.ToString());
                    break;
            }
        }

        Console.Write(sb.ToString());
    }
} 