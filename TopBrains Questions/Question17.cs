using System;

class Question17
{
    public static void Main(string[] args)
    {
        Bank obj = new Bank();

        double balance = double.Parse(Console.ReadLine());
        double amount = double.Parse(Console.ReadLine());

        obj.Balance = balance;
        Console.WriteLine($"Current Balance: {obj.Transaction(amount)}");

    }


}

public class Bank
{
    public double Balance { get; set; }

    public double Transaction(double amount)
    {
        if(amount > 0)
        {
            Balance += amount;
        }
        else if (amount <= 0)
        {
            if(Balance > Math.Abs(amount))
            {
                Balance+=amount;
            }
            else
            {
                Console.WriteLine("Insuffiecient balance");
            }
        }
        return Balance;
    }
}