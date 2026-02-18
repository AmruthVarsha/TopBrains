using System;

public class Assignment5
{
    public static void Main(string[] args){
        bool endLoop = false;
        LinkedList<string> list = new LinkedList<string>();

        while(!endLoop){

            Console.WriteLine("\n\nLinkedList Operations:\n1. Add Student\n2. Display Students\n3. Update Student\n4. Delete Student by Name\n5. Clear List\n6. Exit");

            Console.Write("\nEnter your choice (1-6): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(list);
                    break;
                case 2:
                    DisplayStudents(list);
                    break;
                case 3:
                    UpdateStudent(list);
                    break;
                case 4:
                    DeleteStudent(list);
                    break;
                case 5:
                    ClearList(list);
                    break;
                case 6:
                    endLoop=true;
                    break;
                default:
                    Console.WriteLine("Invalid Command.");
                    break;


            }
        }
    }

    public static void AddStudent(LinkedList<string> list)
    {
        Console.Write("Enter the student's name: ");
        string input=Console.ReadLine();
        list.AddLast(input);
        Console.WriteLine($"{input} added to the list");
    }

    public static void DisplayStudents(LinkedList<string> list)
    {
        Console.WriteLine("Students in the list: ");
        foreach(string i in list)
        {
            Console.WriteLine(i);
        }
    }

    public static void UpdateStudent(LinkedList<string> list)
    {
        Console.Write("Enter the current Student name to update: ");
        string old=Console.ReadLine();
        Console.Write("Enter the new Student name: ");
        string newName=Console.ReadLine();

        if (list.Contains(old))
        {
            list.Find(old).Value = newName;
            Console.WriteLine($"{old} updated to {newName}");
        }
        else
        {
            Console.WriteLine($"{old} not found in the list");
        }
    }

    public static void DeleteStudent(LinkedList<string> list)
    {
        Console.Write("Enter student name to delete: ");
        string name = Console.ReadLine();
        if (list.Contains(name))
        {
            list.Remove(name);
            Console.WriteLine($"{name} removed from the list.");
        }
        else
        {
            Console.WriteLine($"{name} not found in list");
        }
    }
    public static void ClearList(LinkedList<string> list)
    {
        list.Clear();
        Console.WriteLine("The list has been cleared.");
    }
}