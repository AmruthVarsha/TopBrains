using System;
using System.ComponentModel.DataAnnotations;

public class Assignment2
{

    public static List<Movie> MovieList = new List<Movie>()
    {
      new Movie(){Title = "RRR", Artist = "RamCharan", Genre = "Action", Rating = 4},  
      new Movie(){Title = "Bahubali", Artist = "Prabhas", Genre = "Historic", Rating = 5},  
      new Movie(){Title = "Kalki", Artist = "Prabhas", Genre = "Sci-fi", Rating = 4},  
      new Movie(){Title = "Saaho", Artist = "Prabhas", Genre = "Action", Rating = 3},  
      new Movie(){Title = "Kannappa", Artist = "Vishnu", Genre = "Historic", Rating = 2},  
      new Movie(){Title = "Evaru", Artist = "Adivi sesh", Genre = "Thriller", Rating = 4}  
    };

    public static void Main(string[] args)
    {

        Console.Write("Enter Movie detials seperated by commma (Title,Artist,Genre,Rating): ");
        string details = Console.ReadLine();

        Assignment2 assignment2 = new Assignment2();

        assignment2.AddMovie(details);
        Console.Write("Enter genre to search: ");
        string genre = Console.ReadLine();
        List<Movie> MovieListByGenre = assignment2.ViewMoviesByGenre(genre);
        if (MovieListByGenre.Count == 0)
        {
            Console.WriteLine($"No movies found in genre {genre}");
        }
        foreach(Movie i in MovieListByGenre)
        {
            Console.WriteLine($"{i.Title} | {i.Artist} | {i.Genre} | {i.Rating}");
        }

        List<Movie> MovieListByRating  = assignment2.ViewMoviesByRating();
        foreach(Movie i in MovieListByRating)
        {
            Console.WriteLine($"{i.Title} | {i.Artist} | {i.Genre} | {i.Rating}");
        }
        
    }

    public void AddMovie(string MovieDetails)
    {
        
        string[] MovieDetailsArr = MovieDetails.Split(",");
        Movie movie = new Movie();
        movie.Title = MovieDetailsArr[0];
        movie.Artist = MovieDetailsArr[1];
        movie.Genre = MovieDetailsArr[2];
        movie.Rating = int.Parse(MovieDetailsArr[3]);

        MovieList.Add(movie);
    }

    public List<Movie> ViewMoviesByGenre(string genre)
    {
        List<Movie> MovieListByGenre = new List<Movie>();
        foreach(Movie movie in MovieList)
        {
            if (movie.Genre.Equals(genre))
            {
                MovieListByGenre.Add(movie);
            }
        }
        return MovieListByGenre;
    }

    public List<Movie> ViewMoviesByRating()
    {
        var movies = MovieList.OrderBy(movie => movie.Rating).ToList();

        return movies;
    }
}

public class Movie
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }

    
}