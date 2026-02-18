using System;

public class Assignment8
{
    public static void Main(string[] args)
    {
        string input=Console.ReadLine();
        string[] arr=input.Split(" ");

        arr = arr.OrderByDescending( p => p.Length).ToArray();

        foreach(string i in arr)
        {
            Console.Write(i+" ");
        }
    }
}