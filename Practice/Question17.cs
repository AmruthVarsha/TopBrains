// using System;

// public abstract class BankAccount
// {
//     public string AccountNumber{get; set;}
//     public string CustomerName{get;set;}
//     public double Balance {get; set;}

//     public static List<string> TransactionHistory = new List<string>(); 

//     public virtual void Deposit(double amount)
//     {
//         if (amount <= 0)
//         {
//             throw new InvalidOperationException("Amount should be a postive value");
//         }
//         else
//         {
//             Balance+=amount;
//             TransactionHistory.Add($"Account Number: {AccountNumber}, Operation: Deposit, Amount: {amount}");
//         }
//     }

//     public virtual void Withdraw(double amount)
//     {
//         if(amount <= 0)
//         {
//             throw new InvalidOperationException("Amount should be a postive value");
//         }
//         else if(amount > Balance)
//         {
//             throw new InsufficientBalanceException("Insufficient Balance");
//         }
//         else
//         {
//             Balance-=amount;
//             TransactionHistory.Add($"Account Number: {AccountNumber}, Operation: Withdrawl, Amount: {amount}");
//         }
//     }

//     public abstract decimal CalculateInterest();
// }


// public class SavingsAccount : BankAccount
// {
//     public SavingsAccount(double balance)
//     {
//         if (balance < 5000)
//         {
//             throw new MinimumBalanceException("Minimum balance of a savings account must be above 5000");
//         }
//         else
//         {
//             this.Balance = balance;
//         }
//     }

//     public override void Deposit(double amount)
//     {
//         base.Deposit(amount);
//     }

//     public override void Withdraw(double amount)
//     {
//         if (Balance - amount < 5000)
//         {
//             throw new MinimumBalanceException("Transaction cannot bew proccessed minimum balance must be maintained.");
//         }
//         base.Withdraw(amount);
//     }

//     public override decimal CalculateInterest()
//     {
//         return ((decimal)Balance/100)*7;
//     }
// }

// public class CurrentAccount : BankAccount
// {
//     public decimal OverdraftLimit {get; set;}

//     public override void Deposit(double amount)
//     {
//         base.Deposit(amount);
//     }

//     public override void Withdraw(double amount)
//     {
//         if(amount>Balance && Math.Abs(Balance - amount) <= (double)OverdraftLimit)
//         {
//             Balance-=amount;
//             TransactionHistory.Add($"Account Number: {AccountNumber}, Operation: Withdrawl, Amount: {amount}");
//             return;
//         }
//         base.Withdraw(amount);
//     }

//     public override decimal CalculateInterest()
//     {
//         return ((decimal)Balance/100)*5;
//     }

// }

// public class LoanAccount : BankAccount
// {
//     public override void Deposit(double amount)
//     {
//         throw new InvalidTransactionException("Cannot deposite in a loan account.");
//     }

//     public override void Withdraw(double amount)
//     {
//         base.Withdraw(amount);
//     }

//     public override decimal CalculateInterest()
//     {
//         return ((decimal)Balance/100)*12;
//     }
// }

// public class MinimumBalanceException : Exception
// {
//     public MinimumBalanceException(string message) : base(message){}
// }


// public class InvalidTransactionException : Exception
// {
//     public InvalidTransactionException(string message) : base(message){}
// }

// public class InsufficientBalanceException : Exception
// {
//     public InsufficientBalanceException(string message) : base(message){}
// }


// public class Program
// {
//     public static List<BankAccount> accounts = new List<BankAccount>();
//     public static void Main(string[] args)
//     {
//         bool exit=false;
//         int savingsAccountCount=1,currentAccountCount=1,loanAccountCount=1;

//         while (!exit)
//         {
//             Console.WriteLine("1. Create Account\n2. Deposit Money\n3. Withdraw Money\n4. Transfer Money\n5. View Account Details\n6. View Transaction History\n7. Show Total Bank Balance\n8. Show Top 3 Accounts\n9. Show Accounts with Balance > 50,000\n10. Group Accounts by Type\n11. Exit");
//             Console.Write("Choice: ");
//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Type of Account (Savings,Current,Loan): ");
//                     string type=Console.ReadLine();
//                     Console.Write("Enter Name: ");
//                     string name = Console.ReadLine();
//                     Console.Write("Enter Balance:");
//                     double balance = double.Parse(Console.ReadLine());
//                     BankAccount account;
//                     if (type.Equals("Savings", StringComparison.OrdinalIgnoreCase))
//                     {
//                         account = new SavingsAccount(balance);
//                         account.AccountNumber="SA00"+savingsAccountCount;
//                         account.CustomerName =name;
//                         savingsAccountCount++;
//                     }
//                     else if (type.Equals("Current", StringComparison.OrdinalIgnoreCase))
//                     {
//                         account = new CurrentAccount();
//                         account.AccountNumber="CA00"+currentAccountCount;
//                         account.Balance=balance;
//                         account.CustomerName=name;
//                         currentAccountCount++;

//                     }
//                     else if (type.Equals("Loan", StringComparison.OrdinalIgnoreCase))
//                     {
//                         account = new LoanAccount();
//                         account.AccountNumber="LA00"+loanAccountCount;
//                         account.Balance=balance;
//                         account.CustomerName=name;
//                         loanAccountCount++;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid account type");
//                         break;
//                     }
//                     accounts.Add(account);
//                     break;
//                 case 2:
//                     Console.Write("Enter Accout number: ");
//                     string depositAccountNumber = Console.ReadLine();
//                     Console.Write("Enter the amount: ");
//                     double depositAmount = double.Parse(Console.ReadLine());
//                     BankAccount depositAccount = accounts.FirstOrDefault(a => a.AccountNumber==depositAccountNumber);
//                     if (depositAccount == null)
//                     {
//                         Console.WriteLine($"No Account with accout number {depositAccountNumber} is found.");
//                         break;
//                     }
//                     depositAccount.Deposit(depositAmount);
//                     break;
//                 case 3:
//                     Console.Write("Enter Accout number: ");
//                     string withdrawAccountNumber = Console.ReadLine();
//                     Console.Write("Enter the amount: ");
//                     double withdrawAmount = double.Parse(Console.ReadLine());
//                     BankAccount withdrawAccount = accounts.FirstOrDefault(a => a.AccountNumber==withdrawAccountNumber);
//                     if (withdrawAccount == null)
//                     {
//                         Console.WriteLine($"No Account with accout number {withdrawAccountNumber} is found.");
//                         break;
//                     }
//                     withdrawAccount.Withdraw(withdrawAmount);
//                     break;
//                 case 4:
//                     Console.Write("Enter from account number: ");
//                     string fromAccountNumber = Console.ReadLine();
//                     Console.Write("Enter to account number: ");
//                     string toAccountNumber = Console.ReadLine();
//                     Console.Write("Enter amount: ");
//                     double amount = double.Parse(Console.ReadLine());
//                     TransferMoney(fromAccountNumber,toAccountNumber,amount);
//                     break;
//                 case 5:
//                     foreach(BankAccount i in accounts)
//                     {
//                         Console.WriteLine($"Account number: {i.AccountNumber}, Name: {i.CustomerName}, Balance: {i.Balance}");
//                     }
//                     break;
//                 case 6:
//                     foreach(string transactions in BankAccount.TransactionHistory)
//                     {
//                         Console.WriteLine(transactions);
//                     }
//                     break;
//                 case 7:
//                     double totalBalance = accounts.Sum(a => a.Balance);
//                     Console.WriteLine(totalBalance);
//                     break;
//                 case 8:
//                     var top3Accounts = accounts.OrderByDescending(a => a.Balance).Take(3).ToList();
//                     foreach(BankAccount i in top3Accounts)
//                     {
//                         Console.WriteLine($"Account number: {i.AccountNumber}, Name: {i.CustomerName}, Balance: {i.Balance}");
//                     }
//                     break;
//                 case 9:
//                     var accountsBalGT50k = accounts.Where(a => a.Balance>50000).ToList();
//                     foreach(BankAccount i in accountsBalGT50k)
//                     {
//                         Console.WriteLine($"Account number: {i.AccountNumber}, Name: {i.CustomerName}, Balance: {i.Balance}");
//                     }
//                     break;
//                 case 10:
//                     var groupByAccountType = accounts.GroupBy(a => a.GetType());
//                     foreach(var group in groupByAccountType)
//                     {
//                         Console.WriteLine(group.Key);
//                         foreach(var i in group)
//                         {
//                             Console.WriteLine($"Account number: {i.AccountNumber}, Name: {i.CustomerName}, Balance: {i.Balance}");
//                         }
//                     }
//                     break;
//                 case 11:
//                     exit=true;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }
//         }
//     }

//     public static void TransferMoney(string fromAccountNumber, string toAccountNumber, double amount)
//     {
//         BankAccount fromAccount = accounts.FirstOrDefault(a => a.AccountNumber==fromAccountNumber);
//         if (fromAccount == null)
//         {
//             Console.WriteLine("Invalid account number, From account not found.");
//             return;
//         }
//         BankAccount toAccount = accounts.FirstOrDefault(a => a.AccountNumber==toAccountNumber);
//         if (toAccount == null)
//         {
//             Console.WriteLine("Invalid account number, to account not found.");
//             return;
//         }

//         fromAccount.Withdraw(amount);
//         toAccount.Deposit(amount);
//         return;
//     }
// }