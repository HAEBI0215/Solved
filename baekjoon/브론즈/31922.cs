using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int p = int.Parse(s[1]);
        int c = int.Parse(s[2]);

        int result = Math.Max(a + c, p);

        Console.WriteLine(result);
    }
}