using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Assignment3
{
    public static List<int> numberList = new List<int>();
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(",");

        Assignment3 assignment3 = new Assignment3();

        assignment3.AddNumbers(numbers);
        double gpa = assignment3.GetGPAScored();
        Console.WriteLine($"Gpa: {gpa:F2}");
        Console.WriteLine($"Grade: {assignment3.GetGradeScored(gpa)}");
    }

    public void AddNumbers(string[] numbers)
    {
        foreach(string i in numbers)
        {
            numberList.Add(int.Parse(i));
        }
    }

    public double GetGPAScored()
    {
        if (numberList.Count == 0)
        {
            return -1;
        }
        double gpa = 0;
        foreach(int i in numberList)
        {
            gpa += i*3; 
        }
        gpa = gpa/(numberList.Count()*3);

        return gpa;
    }

    public char GetGradeScored(double gpa)
    {
        if(gpa <5 || gpa > 10)
        {
            return '\0';
        }
        else if (gpa == 10)
        {
            return 'S';
        }
        else if(gpa >=9 && gpa < 10)
        {
            return 'A';
        }
        else if(gpa >=8 && gpa < 9)
        {
            return 'B';
        }
        else if(gpa >=7 && gpa < 8)
        {
            return 'C';
        }
        else if(gpa >=6 && gpa < 7)
        {
            return 'D';
        }
        else if(gpa >=5 && gpa < 6)
        {
            return 'E';
        }
        return '\0';
    }
}