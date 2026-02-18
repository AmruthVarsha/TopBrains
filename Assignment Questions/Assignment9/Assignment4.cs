using System;

public class Assignment4
{
    private static void Main(string[] args)
    {

        StudentManager manager=new StudentManager();
        int n =int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string grade = Console.ReadLine();
            Student student = new Student()
            {
                Id = id,
                Name = name,
                Grade = grade
            };
            manager.AddStudent(student);


        }
        manager.DisplayStudents();
        
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }
}

public class StudentManager
{
    Dictionary<int,Student> dict = new Dictionary<int, Student>();

    public void AddStudent(Student student)
    {
        dict.Add(student.Id , student);
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Student Information: ");
        foreach(KeyValuePair<int,Student> i in dict)
        {
            Console.WriteLine($"ID: {i.Value.Id}, Name: {i.Value.Name}, Grade: {i.Value.Grade}");
        }
    }
}