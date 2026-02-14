using System;

public class Heigth
{
    public static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine());

        if (height < 150)
        {
            Console.WriteLine("Short");
        }
        else if(height>=150 && height < 180)
        {
            Console.WriteLine("Average");
        }
        else if (height >= 180)
        {
            Console.WriteLine("Tall");
        }
    }
}