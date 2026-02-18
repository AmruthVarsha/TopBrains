using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class Assignment7{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<int> list = new List<int>(ParseIntegers(input));
        List<int> oddList = new List<int>(GetOddNumbers(list));
        oddList.Sort();

        foreach(int i in oddList)
        {
            Console.Write(i+" ");
        }

    }

    private static List<int> ParseIntegers(string input)
    {
        List<int> list=new List<int>();
        string[] arr=input.Split(" ");
        foreach(string i in arr)
        {
            int num;
            if(int.TryParse(i,out num))
                list.Add(num);
        }
        return list;
    }

    private  static List<int> GetOddNumbers(List<int> numbers)
    {
        List<int> oddList = new List<int>();
        foreach(int i in numbers)
        {
            if (i % 2 != 0)
            {
                oddList.Add(i);
            }
        }
        return oddList;
    }
}