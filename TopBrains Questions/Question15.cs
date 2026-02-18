using System;

public class IntConversion
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n;
        if(int.TryParse(input,out n))
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Not an integer!!");
        }
    }
}