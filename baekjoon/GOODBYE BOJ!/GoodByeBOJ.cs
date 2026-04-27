// 악마의 유혹 번외
// 문제
// 이 문제에 제출을 하면 1년(31,557,600초) 동안 모든 문제에 제출을 할 수 없다.

// 출처
// 문제를 만든 사람: baekjoon
// 채점 및 기타 정보
// 제출한 후 다른 소스를 제출하려면 31557600초가 지나야 한다.
// 메모

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class GoodByeBOJ
{
    public static void Main()
    {
        int currentProblem = 16075;
        string currentProblemName = "악마의 유혹";
        int year = 16;
        int totalDay = 5884;
        int firstProblem = 1000;
        string OwnerName = "BaekJoon";
        string SiteName = "BaekJoon Online Judge";

        string[] messages = {
            $"[Final Submission : {currentProblemName} - {currentProblem}]",
            $"{SiteName}의 첫 번째 문제 {firstProblem}에서 시작된 도전이 대한민국 개발자들의 성지가 되었으며,",
            $"2010.03.19 ~ 2026.04.28 : 햇수로 {year}년, 총 {totalDay}일의 여정이 여기서 마칩니다.",
            $"운영자 {OwnerName}님, 그동안 감사합니다.",
            "\n\"Your code has been Accepted for the last time.\"",
            "Goodbye, Baekjoon Online Judge."
        };

        foreach (string line in messages)
        {
            foreach (char c in line)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Thread.Sleep(200);
        }
    }
}