using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split();
        
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < n; i++)
            set.Add(int.Parse(a[i]));

        int m = int.Parse(Console.ReadLine());
        var b = Console.ReadLine().Split();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < m; i++)
        {
            int x = int.Parse(b[i]);
            sb.Append(set.Contains(x) ? "1 " : "0 ");
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}
