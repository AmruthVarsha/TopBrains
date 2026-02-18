using System;

public class Assignment6
{
    public static void Main(string[] args)
    {
       string name=Console.ReadLine(); 
       string password=Console.ReadLine(); 
       string confirmationPassword=Console.ReadLine();

        Assignment6 assignment6 = new Assignment6();
        try
        {
            User user = assignment6.ValidatePassword(name, password, confirmationPassword);
        }
        catch(PasswordMismatchException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        
        Console.WriteLine("Registered Succesfully.");
    }

    public User ValidatePassword(string name,string password,string confirmationPassword)
    {
        if (!password.Equals(confirmationPassword))
        {
            throw new PasswordMismatchException("Password entered does not match.");

        }
        User user = new User()
        {
            Name =name,
            Password = password,
            ConfirmationPassword = confirmationPassword
        };
        return user;
    }
}

public class PasswordMismatchException : Exception
{
    public PasswordMismatchException(string Message) : base(Message)
    {
        
    }
}

public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string ConfirmationPassword { get; set; }
}