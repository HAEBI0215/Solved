using System;
class Baekjoon32351
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        double bpm = double.Parse(input[1]);
        int K = int.Parse(input[2]);

        int prevMeasure = 1;
        double totalTime = 0.0;

        for (int i = 0; i < K; i++)
        {
            var line = Console.ReadLine().Split();
            int m = int.Parse(line[0]);
            double newBpm = double.Parse(line[1]);

            int length = m - prevMeasure;

            totalTime += length * (240.0 / bpm);

            prevMeasure = m;
            bpm = newBpm;
        }

        int lL = N - prevMeasure + 1;
        totalTime += lL * (240.0 / bpm);

        Console.WriteLine(totalTime.ToString("F12"));
    }
}