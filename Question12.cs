using System;

public class TimeConversion
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sec=n%60;
        int mins = n/60;

        Console.WriteLine($"{mins}:{sec:D2}");
    }
}