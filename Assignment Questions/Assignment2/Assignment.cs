using System;
using System.Runtime.InteropServices;

class Student
{
    public string Name;
    public int Age;
    public string Grade;


    public Student()
    {
        this.Name="Hellen Doe";
        this.Age=21;
        this.Grade="A";
    }

    public Student(String Name,int Age,String Grade)
    {
        this.Name=Name;
        this.Age=Age;
        this.Grade=Grade;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
    }
}

class Car
{
    
    public string Make;
    public  string Model;
    public int Year;

    public Car(string Make,string Model,int Year)
    {
        this.Make=Make;
        this.Model=Model;
        this.Year=Year;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }

    public void DisplayAge()
    {
        Console.WriteLine($"Car Age: {2024-Year} Years");
    }
}


class Person
{
    public String Name { get; set; }
    public int Age { get; set; }
    public String Address { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
    }
}


class StringConversion
{
    public string s1;

    public string StringConverter(string input)
    {
        s1=input;
        return s1.ToUpper();
    }

    public string StringConverter(string input, bool toLower)
    {
        s1=input;
        return s1.ToLower();
    }

    public string StringConverter(string input,int toTitleCase)
    {
        char[] arr = input.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                arr[i]=char.ToUpper(arr[i]);
            }
            else if(arr[i-1]==' ')
            {
                arr[i]=char.ToUpper(arr[i]);
            }
            else
            {
                continue;
            }
        }
        s1=new string(arr);
        return s1;
    }
}