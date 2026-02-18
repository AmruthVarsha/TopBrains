using System;

public class Assignment6{
    private static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        bool endLoop = false;

        while (!endLoop)
        {
            Console.WriteLine("\n\nChoose an operation:\n1: Create (Add a new string)\n2: Read (Display all strings)\n3: Update (Update an existing string)\n4: Delete (Remove a string)\n5: Exit");
            Console.Write("\n\nEnter your Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the string to add: ");
                    string temp = Console.ReadLine();
                    if (set.Contains(temp))
                    {
                        Console.WriteLine($"{temp} already exists in the set.");
                        break;
                    }
                    else
                    {
                        set.Add(temp);
                        Console.WriteLine($"{temp} has been added.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Current items in the set: ");
                    foreach(string i in set)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                    Console.Write("Enter the string to update: ");
                    string old = Console.ReadLine();
                    if(!set.Contains(old)){
                        Console.WriteLine($"{old} does not exist in the set.");
                        break;
                    }
                    Console.Write("Enter the new string: ");
                    string newString = Console.ReadLine();
                        if (set.Contains(newString))
                        {
                            Console.WriteLine($"Update failed. {newString} already exists in the set.");

                            break;
                        }
                        else
                        {
                            set.Remove(old);
                            set.Add(newString);
                            Console.WriteLine($"{old} has been updated to {newString}.");
                            break;
                        }
                    
                    break;
                case 4:
                    Console.Write("Enter the string to delete: ");
                    string del = Console.ReadLine();

                    if (!set.Contains(del))
                    {
                        Console.WriteLine($"{del} does not exist in the set.");
                        break;
                    }

                    set.Remove(del);
                    Console.WriteLine($"{del} has been removed.");
                    break;
                case 5:
                    Console.WriteLine("Exiting....");
                    endLoop = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}