using System;

class Assignment10
{
    public static void Main(string[] args)
    {
        Student student = new Student();

        student.GradeChanged += (int num) =>
        {
            Console.WriteLine($"Grade Changed to: {num}");
        };

        string input = Console.ReadLine();

        int num;
        if(int.TryParse(input,out num))
        {
            student.UpdateGrade(num); 
        }
        else
        {
            Console.WriteLine("Invalid Grade");
        }   
           
    }

}

public class Student
{
    public event Action<int> GradeChanged;

    public void UpdateGrade(int grade)
    {
        GradeChanged?.Invoke(grade);
    }

}