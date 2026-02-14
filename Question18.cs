using System;

class Question18
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        object[] arr= new object[n];
        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input,out int num))
            {
                arr[i]=num;
            }
            else if(bool.TryParse(input,out bool a))
            {
                arr[i] = a;
            }
            else if(input == "null")
            {
                arr[i] = null;
            }
            else
            {
                arr[i] = input;
            }
        }
        int sum=0;
        foreach(object i in arr)
        {
            if(i is int x)
            {
                sum+=x;
            }
        }
        Console.WriteLine(sum);
    }
}