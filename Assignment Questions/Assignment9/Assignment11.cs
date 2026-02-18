using System;

public class Assignment11
{
    public delegate double ArithmeticOperation(double num1, double num2);
    public static void Main(string[] args)
    {

        try
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            ArithmeticOperation arithmeticOperation;
            switch (operation)
            {
                case "add":
                    arithmeticOperation = Add;
                    Console.WriteLine($"The result is: {arithmeticOperation(num1,num2):F2}");
                    break;
                case "substract":
                    arithmeticOperation = Substract;
                    Console.WriteLine($"The result is: {arithmeticOperation(num1,num2):F2}");
                    break;
                case "multiply":
                    arithmeticOperation = Multiply;
                    Console.WriteLine($"The result is: {arithmeticOperation(num1,num2):F2}");
                    break;
                case "divide":
                    arithmeticOperation= Divide;
                    Console.WriteLine($"The result is: {arithmeticOperation(num1,num2):F2}");
                    break;
            }
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
    public static double Substract(double num1, double num2)
    {
        return num1 - num2;
    }
    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    public static double Divide(double num1, double num2)
    {
        if(num2 == 0)
        {
            throw new DivideByZeroException("Error: Division by zero is not allowed.");
        }
        return num1 / num2;
    }
}