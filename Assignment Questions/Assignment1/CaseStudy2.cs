using System;

class CaseStudy2
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public CaseStudy2()
    {
        this.Number1=30;
        this.Number2=15;
    }

    public CaseStudy2(int Number1,int Number2)
    {
        this.Number1=Number1;
        this.Number2=Number2;
    }
    public int Add()
    {
        return Number1+Number2;
    }

    public int Substract()
    {
        return Number1-Number2;
    }

    public int Multiply()
    {
        return Number1*Number2;
    }

    public int Divide()
    {
        return Number1/Number2;
    }
}