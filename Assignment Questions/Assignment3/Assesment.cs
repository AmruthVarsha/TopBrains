using System;

namespace Assesments
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}


public class Employee
{
    public virtual void CalculateSalary(double Salary)
    {
        Console.WriteLine(Salary);
    }
}

public class FullTimeEmployee : Employee
{
    public override void CalculateSalary(double Salary)
    {
        Console.WriteLine(Salary);
    }
}

public class PartTimeEmployee : Employee
{
    public override void CalculateSalary(double Salary)
    {
        Console.WriteLine(Salary - ((Salary/100)*20));
    }
}

public class Intern : Employee
{
    public override void CalculateSalary(double Salary)
    {
        Console.WriteLine(Salary - ((Salary/100)*40));
    }
}