using System;
using System.Collections.Generic;

namespace blockbuster.Models
{

  class Shop
  {
    public string Name { get; private set; }
    public string Address { get; private set; }

    public List<Movie> AvailableMovies { get; set; }
    public List<Movie> RentedMovies { get; set; }

    public Shop(string name, string address)
    {
      Name = name;
      Address = address;
      AvailableMovies = new List<Movie>();
      RentedMovies = new List<Movie>();
    }
    public void ViewMovies(List<Movie> movies)
    {
      for (int i = 0; i < movies.Count; i++)
      {
        Movie movie = movies[i];
        System.Console.WriteLine($"{i + 1}. {movie.Title} - {movie.ReleaseYear} starring {movie.Actors[0].Name}");
      }

    }
    public bool PrintDirectory()
    {
      bool atBlockbuster = true;
      System.Console.WriteLine("To rent a movie press (r), to drop off a movie press (d), to see available movies press (please show me all available movies sir computer), to quit press (q)");
      string input = System.Console.ReadLine();
      switch (input.ToLower())
      {
        case "r":
          RentMovie();
          break;
        case "d":
          ReturnMovie();
          break;
        case "please show me all available movies sir computer":
        case "v":
          ViewMovies(AvailableMovies);
          break;
        case "q":
          atBlockbuster = false;
          break;
      }
      return atBlockbuster;


    }

    public void RentMovie()
    {
      //renting movie logic her
      System.Console.WriteLine("Pick a Movie");
      ViewMovies(AvailableMovies);
      Movie movieToRent = ValidateUserInput(AvailableMovies);
      if (movieToRent == null)
      {
        System.Console.WriteLine("not a valid movie, you have late fees");
        return;
      }
      AvailableMovies.Remove(movieToRent);
      RentedMovies.Add(movieToRent);
      System.Console.WriteLine($"Enjoy watching {movieToRent.Title}");
    }
    public Movie ValidateUserInput(List<Movie> movies)
    {
      string input = Console.ReadLine();
      bool valid = Int32.TryParse(input, out int index);
      if (valid && index > 0 && index <= movies.Count)
      {
        return movies[index - 1];
      }
      return null;

    }

    public void ReturnMovie()
    {
      //returning movie logic here
      System.Console.WriteLine("What movie would you like to return");
      ViewMovies(RentedMovies);
      Movie returnMovie = ValidateUserInput(RentedMovies);
      if (returnMovie == null)
      {
        System.Console.WriteLine("invalid input");
        return;
      }
      AvailableMovies.Add(returnMovie);
      RentedMovies.Remove(returnMovie);
      System.Console.WriteLine($"Thank you for watching {returnMovie.Title}");


    }

  }
}

