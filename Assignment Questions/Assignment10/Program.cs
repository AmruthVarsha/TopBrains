// using System.Data;

// class Program
// {
//     public static void Main()
//     {
//         // LINQ
//         // string[] names = {"Bill","Steve","James", "Mohan"};
//         // // IEnumerable>string> names =
//         // // Query Syntax
//         // var name = from s in names 
//         //             where s.Contains('a') 
//         //             select s;
//         // // Method Syntax
//         // var name1 = names.Where(s1=>s1.Contains('s'));
//         // // execute query
//         // foreach(string s in name1)
//         // {
//         //     Console.WriteLine(s);
//         // }
//         //string collection DataScource
//         // DataSource
//         IList<string> stringList = new List<string>()
//         {
//             "C# Tutorials",
//             "VB.Net Tutorials",
//             "Learn C++",
//             "MVC Tutorials",
//             "Java"
//         };
//         //write query
//         //LINQ Query syntax
//         var result1 = from s in stringList where s.Contains("Tutorials") select s;
//         foreach(var str in result1)
//         {
//             Console.WriteLine(str);
//         }
//         //Data Source
//         //Student list
//         IList<Student> students = new List<Student>()
//         {
//             new Student() {Id=1,Name = "Amruth", Age = 21},
//             new Student() {Id=1,Name = "Amruth", Age = 13},
//             new Student() {Id=1,Name = "Amruth", Age = 18},
//             new Student() {Id=1,Name = "Amruth", Age = 22},
//             new Student() {Id=1,Name = "Amruth", Age = 20}
//         };
//         //write query
//         //Ienumerable<student> Students =
//         var student = from s in students where s.Age>12 && s.Age<20 select s;

//         var studentss = students.Where(s=> s.Age>12 && s.Age<20);

//         foreach(Student i in student)
//         {
//             Console.WriteLine($"{i.Id} | {i.Name} | {i.Age}");
//         }

//         foreach(Student i in studentss)
//         {
//             Console.WriteLine($"{i.Id} | {i.Name} | {i.Age}");
//         }
        

//         var employees = new Employees();

//         employees.Rows.Add(1,"John smith",30,"IT",5000); 
//         employees.Rows.Add(1,"John smith",30,"IT",5000); 
//         employees.Rows.Add(1,"John smith",30,"IT",5000); 
//         employees.Rows.Add(1,"John smith",30,"IT",5000); 

        
//     }
// }
// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
// }


// class Employees: DataTable{
//     public Employees()
//     {
//         this.Columns.Add("Id", typeof(int));
//         this.Columns.Add("Name", typeof(string));
//         this.Columns.Add("Age", typeof(int));
//         this.Columns.Add("Department", typeof(string));
//         this.Columns.Add("Salary", typeof(int));
//     }
// }