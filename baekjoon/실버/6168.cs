using System;
class baekjoon6168 
{
  static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int[] p = new int[n];
        int[] s = new int[n];

        p[0] = (a[0] == 2 ? 1 : 0);
        for (int i = 1; i < n; i++)
            p[i] = p[i - 1] + (a[i] == 2 ? 1 : 0);

        s[n - 1] = (a[n - 1] == 1 ? 1 : 0);
        for (int i = n - 2; i >= 0; i--)
            s[i] = s[i + 1] + (a[i] == 1 ? 1 : 0);

        int ans = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int left = p[i];
            int right = (i + 1 < n) ? s[i + 1] : 0;

            ans = Math.Min(ans, left + right);
        }

        ans = Math.Min(ans, s[0]);
        ans = Math.Min(ans, p[n - 1]);

        Console.WriteLine(ans);
    }
}