using System;
using System.Linq.Expressions;

class Program
{
    public static void Main(string[] args)
    {
        // Employee employee = new Employee();
        // employee[0] = "String 1";
        // employee[1] = "String 2";
        // employee[2] = "String 3";
        // employee[3] = "String 4";
        // employee[4] = "String 5";

        // for(int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(employee[i]);
        // }

        // Console.WriteLine("Value at Third index is {0}",employee[0]);
        // Console.WriteLine("Value String 4 is at index {0}",employee["String 4"]);


        
        // int result=0,num1=0,num2=0;
        // try
        // {
        //     Console.Write("Enter a number: ");
        //     num1 = int.Parse(Console.ReadLine());
        //     Console.Write("Enter a number: "); 
        //     num2 = int.Parse(Console.ReadLine());
        //     result = num1/num2;

        //     int[] arr = new int[5]{1,2,3,4,5};

        //     try
        //     {
        //         for(int i = 0; i < 7; i++)
        //         {
        //             Console.WriteLine(arr[i]);
        //         }
        //     }
        //     catch(IndexOutOfRangeException e)
        //     {
        //         Console.WriteLine(e.Message);
        //     }

        // }
        // catch(FormatException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // catch(DivideByZeroException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // catch(Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // finally
        // {
        //     Console.WriteLine(result); 
        // }

        // try
        // {
        //     throw new MyException("Amruth");
        // }
        // catch(Exception e)
        // {
        //     Console.WriteLine("Exception caught here "+e.ToString());
        // }
        // Console.WriteLine("Last Statement");

        
        Assignment assignment = new Assignment();
        assignment.Task1();
        assignment.Task2();
        assignment.Task3();


    }
}