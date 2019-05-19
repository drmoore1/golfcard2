using System;
namespace GolfCard2.Models
{
  class Player
  {
    public Player(string name)
    {
      Name = name;
      Score1 = 0;
      Score2 = 0;
      Score3 = 0;
      Score4 = 0;
      Score5 = 0;
      Score6 = 0;

    }
    public string Name { get; set; }
    public int Score1 { get; set; }
    public int Score2 { get; set; }
    public int Score3 { get; set; }
    public int Score4 { get; set; }
    public int Score5 { get; set; }
    public int Score6 { get; set; }

  }
}