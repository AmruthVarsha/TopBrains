using System;

public class LargestNumber
{
    public static void Main(string[] args)
    {
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        int c=int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Largest Number: "+a);
            }
            else
            {
                Console.WriteLine("Largest Number: "+c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Largest Number: "+b);
            }
            else
            {
                Console.WriteLine("Largest Number: "+c);
            }
        }
    }
}