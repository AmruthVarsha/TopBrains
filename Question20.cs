using System;

class Question20{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        Shape[] shape = new Shape[n];

        for(int i = 0; i < n; i++)
        {
            arr[i]=Console.ReadLine();
            if (arr[i][0] == 'C')
            {
                shape[i] = new Circle();
            }
            else if(arr[i][0] == 'R')
            {
                shape[i] = new Rectangle();
            }
            else if(arr[i][0] == 'T')
            {
                shape[i] = new Triangle();
            }
        }
        int j=0;
        foreach(string s in arr)
        {
            shape[j].Calculate(s);
            Console.WriteLine(shape[j].Area);
            j++;
        }

    }
}

public abstract class Shape
{
    public decimal Area { get; set; }

    public abstract void Calculate(string arr);
}

public class Circle : Shape
{

    public override void Calculate(string s)
    {
        string[] arr = s.Split(" ");

        Area = (decimal)3.14 * decimal.Parse(arr[1])*decimal.Parse(arr[1]);

    }
}

public class Rectangle : Shape
{

    public override void Calculate(string s)
    {
        string[] arr = s.Split(" ");

        Area =decimal.Parse(arr[1]) * decimal.Parse(arr[2]);

    }
}
public class Triangle : Shape
{

    public override void Calculate(string s)
    {
        string[] arr = s.Split(" ");

        Area = (decimal)0.5 * decimal.Parse(arr[1]) * decimal.Parse(arr[2]);

    }
}