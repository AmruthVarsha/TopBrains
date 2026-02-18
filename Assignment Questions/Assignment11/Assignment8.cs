using System;

public class Assignment8
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string phoneNumber = Console.ReadLine();

        Assignment8 assignment8=new Assignment8();
        try
        {
            User user = assignment8.ValidatePhoneNumber(name,phoneNumber);
        }
        catch(InvalidPhoneNumberException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine("user registered successfully");

    }

    public User ValidatePhoneNumber(string name,string phoneNumber)
    {
        if(phoneNumber.Length != 10)
        {
            throw new InvalidPhoneNumberException("Invalid phone number.");
        }

        return new User
        {
            Name = name,
            PhoneNumber = phoneNumber
        };
    }
}

public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string Message) : base(Message)
    {
        
    }
}

public class User
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}