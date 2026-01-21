using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int upto = int.Parse(Console.ReadLine());

        for(int i = 1; i <= upto; i++)
        {
            Console.WriteLine($"{n} * {i} = {n*i}");
        }
    }
}