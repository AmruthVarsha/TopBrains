using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Collections.Generic;
using System.Transactions;
using System.Collections;
using Microsoft.VisualBasic;

class Assignment
{
    public void Problem1(out double average)
    {
        Console.Write("Enter the number of products: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine("Enter positive values: ");
        for(int i = 0; i < n; i++)
        {
            int temp=int.Parse(Console.ReadLine());
            while (true)
            {
                if (temp < 0)
                {
                    Console.WriteLine("Enter positve integer!");
                }
                else
                {
                    arr[i]=temp;
                    break;
                }
            }
        }
        average=0;
        int sum=0;
        for(int i = 0; i < n; i++)
        {
            sum+=arr[i];
        }
        average=(double)(sum/n);

        Array.Sort(arr);
        Console.WriteLine("Array after sorting: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine("\n\nReplacing below average values with 0: ");
        for(int i = 0; i < n; i++)
        {
            if (arr[i] < average)
            {
                arr[i]=0;
            }
            Console.Write(arr[i]+" ");
        }


        Console.WriteLine($"\n\nOriginal Array size: {arr.Length}");
        Array.Resize(ref arr,arr.Length+5);
        Console.WriteLine($"Array size after adding 5 new positions {arr.Length}");

        for(int i = n; i < arr.Length; i++)
        {
            arr[i]=(int)average;            
        }

        Console.WriteLine("\n\nArray after filling newly added positions with average: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");            
        }

        Console.WriteLine("\n\nArray alongside its index values: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Value at index {i} is: {arr[i]}");            
        }


    }

    public void Problem2(out int rows,out int[,] res)
    {
        Console.Write("Enter the number of Branches: ");
        int n=int.Parse(Console.ReadLine());
        Console.Write("Enter the number of Months: ");
        int m=int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,m];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write($"Enter Branch {i+1} month {j+1} sales: ");
                matrix[i,j]=int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        int highestSale=0;
        for(int i = 0; i < n; i++)
        {
            int total=0;
            for(int j = 0; j < m; j++)
            {
                total+=matrix[i,j];
            }
            Console.WriteLine($"Total sale if Branch {i+1} is: {total}");
            highestSale=Math.Max(highestSale,total);
        }
        Console.WriteLine($"Global highest sale is: {highestSale}");

        res = matrix;
        rows=n;
    }


    public void Problem3(int n,int[,] matrix)
    {
        int[][] jaggedArray= new int[n][];
        double average=0;
        int total=0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                total+=matrix[i,j];
            }
            average=(double)total/matrix.GetLength(1);
            total =0;
            int columnLength=0;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] >= average)
                {
                    columnLength++;
                }
            }  
            jaggedArray[i]= new int[columnLength];

            for(int j = 0,k=0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] >= average)
                {
                    jaggedArray[i][k++]=matrix[i,j];
                }
            }
        }

        Console.WriteLine("Created Jagged Array is : ");
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < jaggedArray[i].Length; j++)
            {

                Console.Write(jaggedArray[i][j]+" ");
            }
            Console.WriteLine();
        }

    }


    public void Problem4()
    {
        Console.Write("Enter the number of Customers: ");
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        Console.WriteLine("Enter Customer ID's: ");
        for(int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        int originalSize=list.Count();
        HashSet<int> set = new HashSet<int>();
        foreach(int i in list)
        {
            set.Add(i);
        }
        list.Clear();
        foreach(int i in set)
        {
            list.Add(i);
        }
        int revisedSize = list.Count();
        Console.WriteLine("Customer ID's after removing duplicates: ");
        foreach(int i in list)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine($"\nThe Number of duplicate entries removed are: {originalSize-revisedSize}");

    }

    public void Problem5(double average)
    {
        Console.Write("Enter the number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        Dictionary<int,double> dict = new Dictionary<int, double>();
        Console.WriteLine("Enter the the transaction Id and Amount: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Amount: ");
            double Amount = double.Parse(Console.ReadLine());
            if (dict.ContainsKey(Id))
            {
                continue;
            }
            dict.Add(Id,Amount);
        }
        SortedList<int,double> list = new SortedList<int, double>();

        foreach(KeyValuePair<int,double> i in dict)
        {
            if (i.Value >= average)
            {
                list.Add(i.Key,i.Value);
            }
        }

        foreach(KeyValuePair<int,double> i in list)
        {
            Console.WriteLine($"Id: {i.Key} , Amount: {i.Value}");
        }
    }

    public void Problem6()
    {
        Queue<string> q=new Queue<string>();
        Stack<string> st=new Stack<string>();

        Console.Write("Enter the number of processes: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Processes: ");
        for(int j = 0; j < n; j++)
        {
            string input = Console.ReadLine();
            q.Enqueue(input);
            st.Push(input);
        }

        List<string> processed = new List<string>();
        int i=0;
        while(q.Count()>0)
        {
            processed.Add(q.Dequeue());
            Console.WriteLine($"Processing: {processed[i]}");
            i++;
        }

        List<string> undone = new List<string>();
        undone.Add(st.Pop());
        undone.Add(st.Pop());
        Console.WriteLine($"Undo: {undone[0]}");
        Console.WriteLine($"Undo: {undone[1]}");

        foreach(string item in processed)
        {
            Console.WriteLine($"Processed : {item}");
        }
        foreach(string item in undone)
        {
            Console.WriteLine($"Undone : {item}");
        }

    }

    public void Problem7()
    {
        Console.Write("Enter the number of Users: ");
        int n=int.Parse(Console.ReadLine());
        Hashtable table = new Hashtable();
        Console.WriteLine("Enter the the data of users: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Role: ");
            string role = Console.ReadLine();
            table.Add(userName,role);
        }
        ArrayList list = new ArrayList();
        foreach(DictionaryEntry i in table)
        {
            list.Add(i.Key);
        }
        Console.WriteLine("Table Data: ");
        foreach(DictionaryEntry i in table)
        {
            Console.WriteLine($"UserName: {i.Key} , Role: {i.Value}");
        }
        Console.WriteLine("ArrayList data: ");
        foreach(string i in list)
        {
            Console.WriteLine($"UserName: {i}");
        }
    }
}