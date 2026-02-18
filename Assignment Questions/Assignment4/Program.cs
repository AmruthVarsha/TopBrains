using System;
using System.Data;
using System.Data.Common;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        // int[] arr; // Array declaration.
        // arr = new int[5]; // Array initialization.

        // arr[0] = 10;
        // arr[1] = 20;
        // arr[2] = 30;
        // arr[3] = 40;
        // arr[4] = 50;

        // int length = arr.Length;
        // Console.WriteLine(length);
        // Console.WriteLine(arr.GetLength(0));// Here 0 represents the dimension, for a 2D array 0 is a dimen and 1 is another.

        // for(int i = 0; i < arr.Length; i++)
        // {
        //     Console.WriteLine(arr[i]);
        // }
        // foreach(int i in arr)
        // {
        //     Console.WriteLine(i);
        // }

        // char[] ch={'H','E','L','L','O',' ','W','O','R','L','D','\0'};
        // char[] ch1=new char[10];
        // for(int i = 0; i < ch1.Length; i++)
        // {
        //     ch1[i]=char.Parse(Console.ReadLine());
        // }
        // foreach(char c in ch)
        // {
        //     Console.Write(c);
        // }
        // Console.WriteLine();
        // foreach(char c in ch1)
        // {
        //     Console.Write(c);
        // }


        // string[] empNames = new string[5];
        // Console.WriteLine("Enter Employee Names: ");
        // for(int i = 0; i < empNames.Length; i++)
        // {
        //     empNames[i]=Console.ReadLine();
        // }

        // Console.WriteLine("Employee Names are: ");
        // for(int i = 0; i < empNames.Length; i++)
        // {
        //     Console.WriteLine(empNames[i]);
        // }


        // int[] arr = {1,2,3,4,5}; //Array is a reference type so it is by default PassByReference.

        // Program program = new Program();
        // program.Display(arr);
        // foreach(int i in arr)
        // {
        //     Console.WriteLine(i);
        // }




        // int[,] arr=new int[3,3];

        // for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j=0;j<arr.GetLength(1); j++)
        //     {
        //         arr[i,j]=int.Parse(Console.ReadLine());
        //     }
        // }

        // for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j=0;j<arr.GetLength(0); j++)
        //     {
        //         Console.Write(arr[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }


        // Practice practice = new Practice();

        // practice.PrintArray();

        // practice.PrintReverse();

        // practice.ArraySum();

        // practice.CopyArray();

        // practice.Duplicate();

        // practice.PrintUnique();

        // practice.MergeAndSort();

        // practice.Frequency();

        // practice.MinMax();

        // practice.EvenOdd();

        // practice.AscSort();

        // practice.DescSort();

        // practice.SortedInsert();

        // practice.UnsortedInsert();

        // practice.DeleteEle();

        int[] arr = new int[6]{50,20,30,10,40,60};

        Console.WriteLine($"Array Index of value 60 is : {Array.IndexOf(arr,60)}");
        Console.WriteLine($"Array value at index 3 is : {arr.GetValue(3)}");
        Console.WriteLine($"Array is FixedSize : {arr.IsFixedSize}");
        Console.WriteLine($"Array is ReadOnly : {arr.IsReadOnly}");
        Console.WriteLine($"Array's Rank: {arr.Rank}");



        Console.WriteLine("\n\n\n");
        Console.WriteLine("Before Sorting: ");

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }

        Array.Sort(arr);
        Console.WriteLine("\n\n\n");
        Console.WriteLine("After Sorting and Before reversing: ");
        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("After Reversing");

        Array.Reverse(arr);
        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }

        Employee employee1 = new Employee(){Id=30,Name="Rajesh"}; 
        Employee employee2 = new Employee(){Id=40,Name="Suresh"}; 
        Employee employee3 = new Employee(){Id=20,Name="Mahesh"}; 
        Employee employee4 = new Employee(){Id=60,Name="Jayesh"}; 
        Employee employee5 = new Employee(){Id=10,Name="Ganesh"};

        Employee[] employeeList=new Employee[5]{employee1,employee2,employee3,employee4,employee5};

        Console.WriteLine("\n\n\n\nBefore Sorting");
        foreach(Employee e in employeeList)
        {
            Console.WriteLine(e);
        }

        Array.Sort(employeeList);
        Console.WriteLine("\n\n\nAfter sorting");
        foreach(Employee e in employeeList)
        {

            Console.WriteLine(e);
        } 

        Program program = new Program();
        Employee emp = new Employee
        {
            Id = 80,
            Name = "Amruth Varsha"
        };

        program.PassObject(emp);

        Employee emp6=program.ReturnObject();

        program.PassArrayObject(employeeList);

    }

    public void PassObject(Employee employee)
    {
        Console.WriteLine(employee);
    }

    public Employee ReturnObject()
    {
        Employee employee = new Employee
        {
            Id = 120,
            Name = "Suresh Kumar"
        };
        return employee;
    }

    public void PassArrayObject(Employee[] employee)
    {
        foreach(Employee e in employee)
        {
            Console.WriteLine(e);
        }
    }

    public int[] Display(int[] arr)
    {
        arr[1]=5;
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
        return arr;
    }
}