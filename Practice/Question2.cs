// using System;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography;
// using System.Transactions;

// public class Repository<T>
// {
//     public List<T> list = new List<T>();

//     public void Add(T item)
//     {
//         list.Add(item);
//     }

//     public void Remove(T item)
//     {
//         list.Remove(item);
//     }

//     public List<T> GetAll()
//     {
//         return list;
//     } 

//     public void Find(Predicate<T> condition)
//     {
        
//     }
// }

// public class InvalidTransactionException : Exception
// {
//     public InvalidTransactionException(string message) : base(message)
//     {
        
//     }
// }



// public class BankAccount
// {
//     public delegate void TransactionHandler(string Message);
//     public event TransactionHandler OnTransaction;

//     public void EventCaller(string Message)
//     {
//         OnTransaction?.Invoke(Message);
//     }


// }


// public abstract class Account
// {
//     public int AccountId { get; set; }
//     public string HolderName { get; set; }
//     public double Balance { get; set; }

//     public BankAccount obj { get; set; }

//     public abstract void Deposite(double amount);
//     public abstract void Withdraw(double amount);
//     public virtual string GetDetails()
//     {
//         return $"Account - {AccountId} , HolderName - {HolderName} , Balance - {Balance}";
//     }
// }

// public class SavingsAccount : Account
// {
//     private double _intersetRate;
//     public double  InterestRate {
//         get
//         {
//             return _intersetRate;
//         }
//         set
//         {
//             if(Balance>1000)
//             _intersetRate = value;
//             else
//             _intersetRate = 0;
//         }
//     }

//     public override void Deposite(double amount)
//     {
//         if (amount <= 0)
//         {
//             throw new InvalidTransactionException("Invalid Transaction Enter a positive amount");
//         }
//         else
//         {
//             Balance+=amount;
//             obj.EventCaller($"[{DateTime.Now}] {AccountId} - {amount} Deposited to the account.");
//             Console.WriteLine($"Current Balance: {Balance}");
//         }
//     }

//     public override void Withdraw(double amount)
//     {
//         if (amount <= 0)
//         {
//             throw new InvalidTransactionException("Invalid Transaction Enter a positive amount");
//         }
//         else if(amount > Balance)
//         {
//             throw new InvalidTransactionException("Insufficent Funds in the Account");
//         }
//         else
//         {
//             Balance-=amount;
//             obj.EventCaller($"[{DateTime.Now}] {AccountId} - {amount} Withdrawn from account.");
//         }
//     }

//     public override string GetDetails()
//     {
//         return $"{base.GetDetails()} , InterestRate - {InterestRate}";
//     }

// }

// public class CurrentAccount : Account
// {
//     public double OverdraftLimit { get; set;}

//     public override void Deposite(double amount)
//     {
//         if (amount <= 0)
//         {
//             throw new InvalidTransactionException("Invalid Transaction Enter a positive amount");
//         }
//         else
//         {
//             Balance+=amount;
//             obj.EventCaller($"[{DateTime.Now}] {AccountId} - {amount} Deposited to the account.");
//             Console.WriteLine($"Current Balance: {Balance}");
//         }
//     }

//     public override void Withdraw(double amount)
//     {
//         if (amount <= 0)
//         {
//             throw new InvalidTransactionException("Invalid Transaction Enter a positive amount");
//         }
//         else if (Balance <=0 && Math.Abs(Balance - amount) > OverdraftLimit)
//         {
//             throw new InvalidTransactionException("Invalid Transaction amount breaching overDraft limit");
//         }
//         else if(amount > Balance+OverdraftLimit)
//         {
//             throw new InvalidTransactionException("Insufficent Funds in the Account");
//         }
//         else
//         {
//             Balance-=amount;
//             obj.EventCaller($"[{DateTime.Now}] {AccountId} - {amount} Withdrawn from account.");
//         }
//     }

//     public override string GetDetails()
//     {
//         return $"{base.GetDetails()} , OverDraftLimit - {OverdraftLimit}";
//     }
    
// }

// public class Program
// {
//     public static string File_Path = "Transaction.txt";
//     public static void Main(string[] args)
//     {
//         Repository<Account> repo = new Repository<Account>();
//         repo.Add(new SavingsAccount { AccountId=101, HolderName="Amruth", Balance=75000, InterestRate=4.5 });
//         repo.Add( new SavingsAccount { AccountId=102, HolderName="Ravi", Balance=12000, InterestRate=4.0 });
//         repo.Add(new SavingsAccount { AccountId=103, HolderName="Kiran", Balance=980, InterestRate=3.5 });
//         repo.Add(new CurrentAccount { AccountId=201, HolderName="Nikhil", Balance=25000, OverdraftLimit=10000 });
//         repo.Add(new CurrentAccount { AccountId=202, HolderName="Pankaj", Balance=-2000, OverdraftLimit=5000 });
//         repo.Add(new CurrentAccount { AccountId=203, HolderName="Suresh", Balance=90000, OverdraftLimit=20000});

//         BankAccount bankAccount = new BankAccount();
//         bankAccount.OnTransaction+=TransactionLog;
//         bankAccount.OnTransaction+=ShowMessage;

//         var acc = repo.list.Where(a => a.Balance>50000).ToList();
//         foreach(Account i in acc)
//         {
//             Console.WriteLine(i.GetDetails());
//         }

//         var acc3 = repo.list.OrderByDescending(a => a.Balance).Take(3).ToList();
//         foreach(Account i in acc3)
//         {
//             Console.WriteLine(i.GetDetails());
//         }

//         IEnumerable<Account> savingAcc = repo.list.OfType<SavingsAccount>();
//         foreach(Account i in savingAcc)
//         {
//             Console.WriteLine(i.GetDetails());
//         }

//         IEnumerable<Account> CurrentAcc = repo.list.OfType<CurrentAccount>();
//         foreach(Account i in CurrentAcc)
//         {
//             Console.WriteLine(i.GetDetails());
//         }

//         foreach(Account i in repo.list)
//         {
//             i.obj = bankAccount;
//         }
//         try{
//         foreach(Account i in repo.list)
//         {
            
//             if(i.AccountId == 101)
//             {
//                 i.Deposite(5000);
//             }
//             if(i.AccountId == 102)
//             {
//                 i.Withdraw(2000);
//             }
//             if(i.AccountId == 103)
//             {
//                 i.Withdraw(2000);
//             }
//             if(i.AccountId == 201)
//             {
//                 i.Withdraw(30000);
//             }
//         }
//         }
//         catch(InvalidTransactionException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         foreach(Account i in repo.list)
//         {
//             if(i.AccountId == 201)
//             {
//                 i.Withdraw(30000);
//             }
//         }
//     }

//     public static void TransactionLog(string Message)
//     {
//         using(StreamWriter sw = new StreamWriter(File_Path, true))
//         {
//             sw.WriteLine(Message);
//         }
//     }

//     public static void ShowMessage(string Message)
//     {
//         Console.WriteLine(Message);
//     }
// }