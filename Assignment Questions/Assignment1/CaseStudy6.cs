using System;

class CaseStudy6
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }

    public void Add()
    {
        Result = Number1+Number2;
        Console.WriteLine($"Sum of two numbers {Number1} and {Number2} is {Result}");
    }
}