using System;
using blockbuster.Models;

namespace blockbuster
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Blockbuster, we are out of business");
      Shop myShop = new Shop("blockbuster", "2300 Broadway Ave");
      Movie up = new Movie("Up", "Old Man misses ungrateful grandson", "2009");
      Movie longShot = new Movie("LongShot", "Seth Rogan acts awkward around a female yet again", "2019");
      Movie dirtyDancing = new Movie("Dirty Dancing", "Male attracted to pre-teen female half his age who has too high of expectations of love", "1987");
      Actor oldMan = new Actor("Seth Rogan?");
      Actor sethRogan = new Actor("Seth Rogan!!!");
      Actor patrickSwayze = new Actor("Fit Seth Rogan dressed like Swayze!!");
      myShop.AvailableMovies.Add(up);
      myShop.AvailableMovies.Add(longShot);
      myShop.AvailableMovies.Add(dirtyDancing);
      up.Actors.Add(oldMan);
      longShot.Actors.Add(sethRogan);
      dirtyDancing.Actors.Add(patrickSwayze);
      myShop.ViewMovies(myShop.AvailableMovies);
      bool atBlockbuster = true;
      while (atBlockbuster)
      {
        if (!myShop.PrintDirectory())
        {
          atBlockbuster = false;
        }

      }





    }

  }
}
