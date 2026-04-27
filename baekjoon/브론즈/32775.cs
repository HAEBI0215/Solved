public class main
{
    public static void Main()
    {
        int S = int.Parse(Console.ReadLine());
        int F = int.Parse(Console.ReadLine());

        if (S <= F)
        {
            Console.WriteLine("high speed rail");
        }
        else
        {
            Console.WriteLine("flight");
        }
    }
}