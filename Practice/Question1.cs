// using System;
// using System.ComponentModel.DataAnnotations;

// public abstract class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double BasicSalary { get; set; }

//     public abstract double CalculateSalary();

//     public virtual string GetDetails()
//     {
//         return $"Id: {Id}, Name: {Name}";
//     }
// }

// public interface IBonus
// {
//     public double CalculateBonus(double salary);
// }

// public class PermanentEmployee : Employee, IBonus
// {
//     public double HRA { get; set; }

//     public override double CalculateSalary()
//     {
//         double Salary = BasicSalary + HRA;
//         Salary += CalculateBonus(Salary);
//         return Salary;
//     }

//     public override string GetDetails()
//     {
//         return $"Id: {Id} Name: {Name} HRA: {HRA}";
//     }
//     public double CalculateBonus(double salary)
//     {
//         return 0.1 * salary;
//     }
// }

// public class ContractEmployee : Employee
// {
//     public int WorkingDays { get; set; }

//     public override double CalculateSalary()
//     {
//         return BasicSalary * WorkingDays;
//     }

//     public override string GetDetails()
//     {
//         return base.GetDetails();
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new PermanentEmployee{Id=1,Name="Amruth",BasicSalary=60000,HRA=5000},
//             new PermanentEmployee{Id=2,Name="Nuthan",BasicSalary=57000,HRA=3000},
//             new PermanentEmployee{Id=3,Name="Ranjan",BasicSalary=42000,HRA=4000},
//             new ContractEmployee{Id=4,Name="Ravi",BasicSalary=15000,WorkingDays=90},
//             new ContractEmployee{Id=5,Name="Pankaj",BasicSalary=12000,WorkingDays=90},
//             new ContractEmployee{Id=6,Name="Gopi",BasicSalary=100000,WorkingDays=90},
//         };

//         Dictionary<int,Employee> employeeMap = new Dictionary<int, Employee>();
//         foreach(Employee i in employees)
//         {
//             employeeMap.Add(i.Id,i);
//         }

//         var EmpSalGreaterThan50k = employees.Where(e => e.CalculateSalary()>50000).ToList();
//         foreach(Employee e in EmpSalGreaterThan50k)
//         {
//             Console.WriteLine($"{e.Name} - {e.CalculateSalary()} - {e.GetDetails()}");
//         }

//         IEnumerable<Employee> PE = employees.OfType<PermanentEmployee>();
//         foreach(Employee e in PE)
//         {
//             Console.WriteLine(e.GetDetails());
//         }

//         var emp = employees.Where(e => e.CalculateSalary() == employees.Max(i => i.CalculateSalary())).ToList();
//         foreach(Employee e in emp)
//         {
//             Console.WriteLine(e.GetDetails());
//         }

//         foreach(Employee e in employees)
//         {
//             Console.WriteLine($"{e.Name} - {e.CalculateSalary()} - {e.GetDetails()}");
//         }
//     }
// }