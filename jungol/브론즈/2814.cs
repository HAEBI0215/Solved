// 입력 : 0과 1로만 이루어진 30자리 이하의 2진수를 입력받는다
// 출력 : 입렵된 2진수를 10진수로 변환하여 출력한다



using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int convertNum = Convert.ToInt32(input, 2);
        Console.WriteLine(convertNum);
    }
}