using System;
using System.Collections.Generic;
public class CustomSorting
{
    public static void Main(string[] args)
    {
        List<Student> list = new List<Student>();
        int n=int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Student student  = new Student();
            student.Name = Console.ReadLine();
            student.Age = int.Parse(Console.ReadLine());
            student.Marks = int.Parse(Console.ReadLine());

            list.Add(student);
        }

        // var SortedList = list.OrderBy(s => s.Marks).ThenBy(s => s.Age).ToList();

        // foreach(Student s in SortedList)
        // {
        //     Console.WriteLine($"Name: {s.Name} , Age: {s.Age} , Marks: {s.Marks}");
        // }

        list.Sort(new StudentComparer());

        
        foreach(Student s in list)
        {
            Console.WriteLine($"Name: {s.Name} , Age: {s.Age} , Marks: {s.Marks}");
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if(x.Marks != y.Marks)
        {
            return y.Marks.CompareTo(x.Marks);
        }

        return x.Age.CompareTo(y.Age);
    }
}