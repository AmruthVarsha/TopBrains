using System;
using System.Collections;

class Assignment1
{
    private static void Main(string[] args)
    {
        ArrayList names = new ArrayList();

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToUpper().Equals("STOP"))
            {
                break;
            }
            else if (IsValidName(input))
            {
                if (!IsNameInCollection(names,input))
                {
                    names.Add(input);
                    Console.WriteLine($"{input} added to the collection.");
                }
                else
                {
                    Console.WriteLine($"{input} is already in the collection.");
                }
            }
            
        }
        DisplayStudentNames(names);
    }

    private static bool IsValidName(string name)
    {
        if(name != null && name != string.Empty)
        {
            return true;
        }
        return false;
    }

    private static bool IsNameInCollection(ArrayList names,string name)
    {
        foreach(string i in names)
        {
            if(i.ToUpper().Equals(name.ToUpper()))
            {
                return true;
            }
        }
        return false;
    }

    private static void DisplayStudentNames(ArrayList names)
    {
        Console.WriteLine("Uniques student names entered: ");
        foreach(string i in names)
        {
            Console.WriteLine(i);
        }
    }
}