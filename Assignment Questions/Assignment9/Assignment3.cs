using System;
using System.Collections;

public class Assignment3
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList();

        while (true)
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            if (title.Equals("quit"))
            {
                break;
            }
            if (!IsValidInput(title))
            {
                Console.WriteLine("Invalid Input");
                continue;
            }
            Console.Write("Enter Artist: ");
            string artist = Console.ReadLine();
            if(!IsValidInput(artist)){
                Console.WriteLine("Invalid Input");
                continue;
            }
            Album album = new Album()
            {
                Title = title,
                Artist = artist
            };

            list.Add(album);
        } 
        DisplayAlbums(list);
    }

    private static bool IsValidInput(string input)
    {
        if(input==null || input.Trim() == string.Empty)
        {
            return false;
        }
        return true;
    }

    private static void DisplayAlbums(ArrayList albums)
    {
        foreach(Album i in albums)
        {
            Console.WriteLine($"Title: {i.Title}, Artist: {i.Artist}");
        }
    }
}

public class Album
{
    public string Title { get; set; }
    public string Artist { get; set; }
}