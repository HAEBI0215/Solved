using System;
using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        if (s == "0")
        {
            Console.WriteLine("0");
            return;
        }

        string[] bin =
        {
            "000", "001", "010", "011",
            "100", "101", "110", "111"
        };

        StringBuilder sb = new StringBuilder();

        int first = s[0] - '0';
        sb.Append(Convert.ToString(first, 2));

        for (int i = 1; i < s.Length; i++)
        {
            sb.Append(bin[s[i] - '0']);
        }

        Console.WriteLine(sb.ToString());
    }
}