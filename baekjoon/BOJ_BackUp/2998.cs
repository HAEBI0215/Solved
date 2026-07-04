using System;
using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        while (s.Length % 3 != 0)
        {
            s = "0" + s;
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i += 3)
        {
            int num = (s[i] - '0') * 4
                    + (s[i + 1] - '0') * 2
                    + (s[i + 2] - '0');

            sb.Append(num);
        }

        Console.WriteLine(sb.ToString());
    }
}