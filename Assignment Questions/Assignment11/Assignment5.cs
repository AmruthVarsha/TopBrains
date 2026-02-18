using System;
using System.Runtime.CompilerServices;

public class Assignment5
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double balance = double.Parse(Console.ReadLine());
        double amount = double.Parse(Console.ReadLine());

        Assignment5 assignment5 = new Assignment5();
        try
        {
            EcommerceShop obj = assignment5.MakePayment(name,balance,amount);
        }
        catch(InsufficientWalletBalanceException e)
        {
           Console.WriteLine(e.Message);
           return;
        }
        Console.WriteLine("Payment Successfull");

    }

    public EcommerceShop MakePayment(string name,double balance,double amount)
    {
        if(balance < amount)
        {
            throw new InsufficientWalletBalanceException("Insufficient balance in you digital wallet.");
        }
        EcommerceShop ecommerceShop = new EcommerceShop()
        {
            UserName = name,
            WalletBalance = balance,
            TotalPurchaseAmount = amount
        };

        return ecommerceShop;
    }
}

public class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException(string Message) : base(Message)
    {
        
    }
}

public class EcommerceShop
{
    public string UserName { get; set; }
    public double WalletBalance { get; set; }
    public double TotalPurchaseAmount { get; set; }
}