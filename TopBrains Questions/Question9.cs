using System;

public class FeetToCm
{
    public static void Main(string[] args)
    {
        int feet = int.Parse(Console.ReadLine());
        double cm = (double)feet * 30.48;
        cm = Math.Round(cm,2,MidpointRounding.AwayFromZero);
        Console.WriteLine(cm);
    }
}