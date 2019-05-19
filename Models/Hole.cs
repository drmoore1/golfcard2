using System;
namespace GolfCard2.Models
{
  class Hole
  {
    public Hole(int number, int par, int dist)
    {
      HoleNumber = number;
      Par = par;
      Distance = dist;
    }
    public int Par { get; set; }
    public int Distance { get; set; }
    public int HoleNumber { get; set; }
  }





}