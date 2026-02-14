using System;

public class DecimalRounding
{
    public static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double area = (22.0/7.0)*r*r;

        Console.WriteLine(Math.Round(area,2,MidpointRounding.AwayFromZero));
    }
}