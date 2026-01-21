using System;

public class GCD
{
    public static void Main(string[] args)
    {
       int a=int.Parse(Console.ReadLine()); 
       int b=int.Parse(Console.ReadLine());

       Console.WriteLine($"GCD of {a} and {b} is: {GCDCal(a,b)}"); 
    }

    public static int GCDCal(int a,int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCDCal(b,a%b);

    }
}