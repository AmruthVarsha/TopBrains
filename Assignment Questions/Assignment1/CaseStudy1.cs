using System;

class CaseStudy1
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public CaseStudy1()
    {
        this.Number1=30;
        this.Number2=15;
    }
    public int Add(int number1,int number2)
    {
        return number1+number2;
    }

    public int Substract()
    {
        return Number1-Number2;
    }

    public int Multiply(int number1,int number2)
    {
        return number1*number2;
    }

    public int Divide()
    {
        return Number1/Number2;
    }
}