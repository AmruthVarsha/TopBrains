using System;
using System.Text;
using System.Text.Json;
public class Assigment15
{
    public const string FilePath = "Employee.json";
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> list = new List<Employee>();
        for(int i = 0; i < n; i++)
        {
            
            int id = int.Parse(Console.ReadLine());
            string name=Console.ReadLine();
            string department=Console.ReadLine();

            Employee e = new Employee()
            {
                Id = id,
                Name = name,
                Department = department
            };

            list.Add(e);
        }

        string json = JsonSerializer.Serialize(list);

        File.WriteAllText(FilePath,json);

        string s = File.ReadAllText(FilePath);
        List<Employee> readlist = JsonSerializer.Deserialize<List<Employee>>(s);

        foreach(Employee i in readlist)
        {
            Console.WriteLine($"{i.Id}-{i.Name}-{i.Department}");
        }
        
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}