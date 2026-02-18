using System;
using System.Collections;

public class Assignment9
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] arr=input.Split(" ");

        List<int> list =new List<int>();

        foreach(string i in arr)
        {
            int num;
            if(!int.TryParse(i,out num))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            num=num*num;
            list.Add(num);
        }
        list.Sort();

        foreach(int i in list)
        {
            Console.Write(i+" ");
        }
    }
}