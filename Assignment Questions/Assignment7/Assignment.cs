using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


class Assignment
{
    public void Task1()
    {
        double temperature=0;
        string conversion = string.Empty;

        try
        {
            Console.Write("Enter the temperature: ");
            temperature = double.Parse(Console.ReadLine());
            Console.Write("Enter the conversion type \"C or F\": ");
            conversion = Console.ReadLine().ToUpper();
        }
        catch(SystemException e)
        {
            Console.WriteLine("Error: Invalid input provided.");
            Console.WriteLine("Exception Message: "+e.Message);
            return;

        }

        if (conversion.Equals("C"))
        {
            temperature = (temperature * (9.0/5.0))+32;
            Console.WriteLine($"Temperature in Fahrenheit: {temperature:F2}");
        }
        else if(conversion.Equals("F"))
        {
            temperature = (temperature-32)*(5.0/9.0);
            Console.WriteLine($"Temperature in Celsius: {temperature:F2}");
        }
        else
        {
            Console.WriteLine("Invalid conversion type. Please enter 'F' or 'C'");
        }
    }


    public void Task2()
    {
        string input = Console.ReadLine();

        string[] scores = input.Split(" ");

        CricketMatch cricketMatch = new CricketMatch();

        try{
            for(int i = 0; i< scores.Length; i++)
            {
                cricketMatch.AddPlayerScore(int.Parse(scores[i]));
            }
        }
        catch(InvalidOperationException e)
        {
            Console.WriteLine("Error: "+e.Message);
        }
        catch(ArgumentException e)
        {
            Console.WriteLine("Error: "+e.Message);
        }

    }

    public void Task3()
    {
        Console.Write("Enter space seperated array 1: ");
        string inputArray1 = Console.ReadLine();
        Console.Write("Enter space seperated array 2: ");
        string inputArray2 = Console.ReadLine();
        Console.Write("Enter the index: ");

        int index = -1;

        string[] temp1=inputArray1.Split(" ");
        int[] arr1=new int[temp1.Length];

        string[] temp2=inputArray2.Split(" ");
        int[] arr2=new int[temp2.Length];

        if(arr1.Length != arr2.Length)
        {
            Console.WriteLine("Error: Arrays must have the same length for addition.");
            return;
        }

        try
        {
            
            
            for(int i = 0; i < temp1.Length; i++)
            {
                arr1[i]=int.Parse(temp1[i]);
            }
            
            for(int i = 0; i < temp2.Length; i++)
            {
                arr2[i]=int.Parse(temp2[i]);
            }

            index = int.Parse(Console.ReadLine());

           
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error: Invalid input format. Please enter integers only.");
            Console.WriteLine("Exception Message: "+e.Message);
            return;
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception Message: "+e.Message);
            return;
        }


        int[] arr3 = new int[arr1.Length];

        for(int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = arr1[i]+arr2[i];
        }
        int result=0;
        try
        {
            result = arr3[index];
            Console.WriteLine($"Element at index {index} in the sum array: {result}");
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Error: Index out of range for the sum array.");
            Console.WriteLine($"Exception Message: {e.Message}");

        }
        catch(Exception e)
        {
            Console.WriteLine("Exception Message: "+e.Message);
            return;
        }


    }
}

public class CricketMatch
{
    int[] playerScores = new int[5];
    int CurrentIndex=0;

    public void AddPlayerScore(int score)
    {
            if(score<0 || score > 50)
            {
                throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
            }
            else if (CurrentIndex >= 5)
            {
                throw new InvalidOperationException("Cannot add more than 5 player scores.");
            }
            else
            {
                playerScores[CurrentIndex]=score;
                CurrentIndex++;
            }
    }

    public void CalculateTotalScore()
    {
        int total=0;
        for(int i = 0; i < playerScores.Length; i++)
        {
            total+=playerScores[i];
        }
        Console.WriteLine("Total score is: "+total);
    }
}

