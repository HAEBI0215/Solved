// 입력 : 
// 21억 이하의 양의 정수를 입력받는다 / 잘못된 데이터는 입력되지 않는다
// 하나의 결과가 나온 후에도 계속 새로운 입력을 받다가 0이되면 종료한다
// 최대 10개의 양의 정수가 입력될 수 있다

// 출력 :
// 입력 받은 수의 역과 각 자리의 숫자의 합을 공백으로 구분하여 출력한다
// 유효하지 않은 0은 출력하지 않는다
// 입력받은 수의 역도 21억 이하의 정수이다


using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            
            string reversed = new string(charArray);
            reversed = reversed.TrimStart('0');

            int sum = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    sum += (int)char.GetNumericValue(c);
            }

            if (sum == 0)
                return;
            else
                Console.WriteLine($"{reversed} {sum}");
        }
    }
}