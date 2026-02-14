using System;

public class LuckyNumber
{
    public static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int count=0;
        for(int i = m; i <= n; i++)
        {
            if (!IsPrime(i))
            {
                int s=IsLucky(i);
                int sq = IsLucky(i*i);
                if(s*s == sq)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    public static int IsLucky(int num)
    {
        int sum=0;

        while (num > 0)
        {
            int rem  = num%10;
            sum+=rem;
            num/=10;
        
        }

        return sum;
    }

    public static bool IsPrime(int num)
    {
        if (num<=1)
        {
            return false;
        }
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}