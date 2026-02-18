using System;
using System.Collections;
using System.ComponentModel;

public class Assignment2
{
    private static void Main(string[] args)
    {
        ArrayList list=new ArrayList();
        bool endLoop = false;
        while(!endLoop){
            Console.Write("Enter the command:\nadd\nremove\ndisplay\nexit\n");
            string command = Console.ReadLine();

            switch (command)
            {
                case "add":
                    Console.Write("Enter a number: ");
                    int num;
                    string input = Console.ReadLine();
                    if(int.TryParse(input, out num))
                    {
                        list.Add(num);
                        Console.WriteLine($"{num} added to the number list.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "remove":
                    Console.Write("Enter the number to remove: ");
                    int number = int.Parse(Console.ReadLine());
                    bool found = false;
                    foreach(int i in list)
                    {
                        if(i == number)
                        {
                            list.Remove(number);
                            Console.WriteLine($"{number} removed from the number list.");
                            found=true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"{number} not found in the number list.");
                    }
                    break;
                case "display":
                    Console.WriteLine("Current numbers in the list: ");
                    foreach(int i in list)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case "exit":
                    endLoop = true;
                    break;
                default:
                    Console.WriteLine("Invalid input!!");
                    break;
            }
        }
        
    }
}