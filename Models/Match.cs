using System;
using System.Collections.Generic;

namespace GolfCard2.Models
{
  class Match
  {
    public Match(Course course, List<Player> players)
    {
      Course = course;
      PlayerList = players;
    }
    public List<Player> PlayerList { get; set; }
    public Course Course { get; set; }
  }
}