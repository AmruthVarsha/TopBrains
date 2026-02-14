using System;

class Question19{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        Employee[] emp = new Employee[n];

        for(int i = 0; i < n; i++)
        {
            arr[i]=Console.ReadLine();
            if (arr[i][0] == 'H')
            {
                emp[i] = new HourlyEmployee();
            }
            else if(arr[i][0] == 'S')
            {
                emp[i] = new SalariedEmployee();
            }
            else if(arr[i][0] == 'C')
            {
                emp[i] = new CommisionEmployee();
            }
        }
        int j=0;
        foreach(string s in arr)
        {
            emp[j].Payment(s);
            Console.WriteLine(emp[j].amount);
            j++;
        }

    }
}

public abstract class Employee
{
    public decimal amount { get; set; }

    public abstract void Payment(string arr);
}

public class HourlyEmployee : Employee
{

    public override void Payment(string s)
    {
        string[] arr = s.Split(" ");

        amount = int.Parse(arr[1]) * int.Parse(arr[2]);

    }
}

public class SalariedEmployee : Employee
{

    public override void Payment(string s)
    {
        string[] arr = s.Split(" ");

        amount =int.Parse(arr[1]);

    }
}
public class CommisionEmployee : Employee
{

    public override void Payment(string s)
    {
        string[] arr = s.Split(" ");

        amount = int.Parse(arr[1]) + int.Parse(arr[2]);

    }
}