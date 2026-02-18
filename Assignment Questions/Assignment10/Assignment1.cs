// using System;

// public class Assignment1
// {
//     public static void Main(string[] args)
//     {

//         Account account = new Account();

//         Console.WriteLine("Enter 1 for Deposite: ");
//         Console.WriteLine("Enter 2 for Withdraw: ");
//         Console.WriteLine("Enter 3 to exit: ");
//         int n = int.Parse(Console.ReadLine());

//         while(true){
//             if (n == 1)
//             {
//                 Console.Write("Enter amount to deposite: ");
//                 decimal amount = decimal.Parse(Console.ReadLine());
//                 decimal currentBalance = account.Deposit(amount);
//                 Console.WriteLine($"Current account balance is: {currentBalance}");
//             }
//             else if (n == 2)
//             {
//                 Console.Write("Enter amount to withdraw: ");
//                 decimal amount = decimal.Parse(Console.ReadLine());
//                 decimal currentBalance = account.Withdraw(amount);
//                 Console.WriteLine($"Current account balance is: {currentBalance}");
//             }
//             else if (n == 3)
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input");
//             }
//         }
        
//     }
// }

// public class Account
// {
//     public string AccountNumber { get; set;}
//     public decimal Balance { get; private set; }


//     public decimal Deposit(decimal amount)
//     {
//         try{
//             if(amount > 0)
//             {
//                 Balance += amount;
//             }
//             else if(amount< 0)
//             {
//                 throw new ArgumentException("Deposit amount must be positive.");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid Amount");
//             }
//         }
//         catch(ArgumentException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         return Balance;
//     }

//     public decimal Withdraw(decimal amount)
//     {
//         try{
//             if(amount > 0 && amount <= Balance)
//             {
//                 Balance -= amount;
//             }
//             else if (amount <= 0)
//             {
//                 throw new ArgumentException("Withdrawal amount must be positive.");
//             }
//             else if(amount > Balance)
//             {
//                 throw new InvalidOperationException("Insufficient funds.");
//             }
//         }
//         catch(ArgumentException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         catch(InvalidOperationException e)
//         {
//             Console.WriteLine(e.Message);
//         }

//         return Balance;
//     }
// }
