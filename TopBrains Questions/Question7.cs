using System;


public class SwapWithOutTemp
{
    public static void Main(string[] args)
    {
        int n1=1;
        int n2=2;

        Method1(ref n1,ref n2);
        Console.WriteLine(n1+" "+n2);

        int num1,num2;
        Method2(n1,n2,out num1,out num2);
        Console.WriteLine(num1+" "+num2);

    }

    public static void Method1(ref int num1,ref int num2)
    {
        num1  = num1^num2;
        num2 = num1^num2;
        num1 = num1^num2;
    }

    public static void Method2(int num1,int num2,out int n1,out int n2)
    {
        num1 = num1 ^ num2;
        num2 = num1 ^ num2;
        num1 = num1 ^ num2;

        n1=num1;
        n2=num2;
    }
}

