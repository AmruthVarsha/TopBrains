using System;

public class SummArray
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];

        for(int i = 0; i < n; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }

        int sum=0;

        foreach(int i in arr)
        {
            if (i == 0)
            {
                break;
            }
            else if (i < 0)
            {
                continue;
            }
            else
            {
                sum+=i;
            }
        }
        Console.WriteLine(sum);
    }
}