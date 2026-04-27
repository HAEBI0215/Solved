public class main
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        if (a >= 620 && a <= 780)
            Console.WriteLine("Red");
        else if (a >= 590 && a <= 620)
            Console.WriteLine("Orange");
        else if (a >= 570 && a <= 590)
            Console.WriteLine("Yellow");
        else if (a >= 495 && a <= 570)
            Console.WriteLine("Green");
        else if (a >= 450 && a <= 495)
            Console.WriteLine("Blue");
        else if (a >= 425 && a <= 450)
            Console.WriteLine("Indigo");
        else if (a >= 380 && a <= 425)
            Console.WriteLine("Violet");
    }
}