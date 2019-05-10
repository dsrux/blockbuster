using System;
using System.Collections.Generic;

namespace blockbuster.Models
{

  class Movie
  {
    public string Title { get; set; }
    public string Plot { get; set; }
    public string ReleaseYear { get; set; }
    public List<Actor> Actors { get; set; }

    public Movie(string title, string plot, string releaseYear)
    {
      Title = title;
      Plot = plot;
      ReleaseYear = releaseYear;
      Actors = new List<Actor>();
    }
  }
}
