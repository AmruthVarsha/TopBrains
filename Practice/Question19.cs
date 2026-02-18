using System;
using System.Text;
using System.Text.Json;

public class Student
{
    public int Id {get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
    public string Course {get; set;}

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}, Course: {Course}";
    }
}

public class Program
{
    public static string file_path = "students.dat";
    public static void Main(){
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. add student\n2. View students details\n3. exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int id = int.Parse(Console.ReadLine());
                        string name = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        string course = Console.ReadLine();

                        Student s = new Student()
                        {
                            Id=id,Name=name,Age=age,Course=course
                        };

                        string json = JsonSerializer.Serialize(s);
                        using(StreamWriter sw = new StreamWriter(file_path,true))
                        {
                            sw.WriteLine(json);
                        }
                        break;
                    case 2:
                        using(StreamReader sr=new StreamReader(file_path)){
                            string line;
                            while((line=sr.ReadLine()) != null)
                                {
                                    Student student = JsonSerializer.Deserialize<Student>(line);
                                    Console.WriteLine(student.ToString());
                                }
                        }
                        break;
                    case 3:
                        exit=true;
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;
                        
            }
        }
    }
}