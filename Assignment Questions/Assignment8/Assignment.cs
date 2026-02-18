using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;

class Assignment
{
    public void Task1()
    {

        decimal price=0;
        int quantity=0;

        try{
            price = decimal.Parse(Console.ReadLine());
            

            if(price <= 0)
            {
                throw new InvalidPriceException("Error: Price must be greater than zero.");
            }

            quantity = int.Parse(Console.ReadLine());

            if(quantity <= 0)
            {
                throw new InvalidQunatityException("Error: Quantity must be greater than zero.");
            }
        }
        catch(InvalidPriceException e){
            // Console.WriteLine("Error: Price must be greater than zero.");
            Console.WriteLine(e.Message);
            return;
        }
        catch(InvalidQunatityException e)
        {
            // Console.WriteLine("Error: Quantity must be greater than zero.");
            Console.WriteLine(e.Message);
            return;
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error: Please enter a valid number.");
            Console.WriteLine(e.Message);
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        decimal total = price * (decimal)quantity;
        Console.WriteLine($"{total:F1}");
        
    }

    public void Task2()
    {
        int tickets=0;
        decimal price =0;

        try
        {
            tickets = int.Parse(Console.ReadLine());

            price = decimal.Parse(Console.ReadLine());

            if (tickets <= 0)
            {
                throw new ArgumentException("Error: Number of tickets must be greater than 0.");
            }

            

            if (price <= 0)
            {
                throw new ArgumentException("Error: Price per ticket must be greater than 0.");
            }

        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error: Please enter a valid number.");
            return;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        decimal totalCost = (decimal)tickets * price;

        Console.WriteLine($"Total Ticket Cosr: {totalCost:F1}");
    }


    public void Task3()
    {

        string[] scores = Console.ReadLine().Split(" ");
        CricketMatch cricketMatch = new CricketMatch();

        try{
            foreach(string i in scores)
            {
                cricketMatch.AddScore(int.Parse(i));
            }
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        catch(InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        Console.WriteLine($"Total score of the cricket team: {cricketMatch.CalculateTotalScore()}");
        
    }

    
}


class CricketMatch
{
    int[] playerScores=new int[5];
    int currentIndex=0;

    public void AddScore(int score)
    {
        if(score < 0 || score > 50)
        {
            throw new ArgumentException("Error: Invalid score. Score must be between 0 and 50.");
        }
        if(currentIndex >= 5)
        {
            throw new InvalidOperationException("Error: Cannot add more than 5 player scores.");
        }
        playerScores[currentIndex] = score;
        currentIndex++;

    }
    public int CalculateTotalScore()
    {
        int total=0;
        foreach(int i in playerScores)
        {
            total+=i;
        }
        return total;
    }
}


class InvalidPriceException : SystemException
{
    public InvalidPriceException() : base()
    {
        
    }

    public InvalidPriceException(string Message) : base(Message)
    {
        // Console.WriteLine(Message);
    }
}

class InvalidQunatityException : SystemException
{
    public InvalidQunatityException() : base()
    {
        
    }
    public InvalidQunatityException(string Message) : base(Message)
    {
        // Console.WriteLine(Message);
    }
}