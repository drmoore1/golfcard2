using System;
using System.Collections.Generic;

namespace GolfCard2.Models
{
  class Match
  {
    int CurrentRound = 1;
    public void StartMatch()
    {

      {
        GameScores();
      }
    }
    public void GameScores()
    {
      Console.Clear();
      System.Console.WriteLine($"Hole 1 at {this.Course.Name}");
      foreach (Player player in PlayerList)
      {

        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6}");
        System.Console.WriteLine($"Please input score for {player.Name}");
        player.Score1 = Convert.ToInt32(System.Console.ReadLine());

      }
      Console.Clear();
      System.Console.WriteLine($"Hole 2 at {this.Course.Name}");
      foreach (Player player in PlayerList)
      {
        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6}");
        System.Console.WriteLine($"Please input score for {player.Name}");
        player.Score2 = Convert.ToInt32(System.Console.ReadLine());
      }
      Console.Clear();
      System.Console.WriteLine($"Hole 3 at {this.Course.Name}");
      foreach (Player player in PlayerList)
      {
        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6}");
        System.Console.WriteLine($"Please input score for {player.Name}");
        player.Score3 = Convert.ToInt32(System.Console.ReadLine());
      }
      Console.Clear();
      System.Console.WriteLine($"Hole 4 at {this.Course.Name}");
      foreach (Player player in PlayerList)
      {
        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6}");
        System.Console.WriteLine($"Please input score for {player.Name}");
        player.Score4 = Convert.ToInt32(System.Console.ReadLine());
      }
      Console.Clear();
      System.Console.WriteLine($"Hole 5 at {this.Course.Name}");
      foreach (Player player in PlayerList)
      {
        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6}");
        System.Console.WriteLine($"Please input score for {player.Name}");
        player.Score5 = Convert.ToInt32(System.Console.ReadLine());
      }
      Console.Clear();
      System.Console.WriteLine($"Hole 6 at {this.Course.Name}");
      foreach (Player player in PlayerList)
      {
        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6}");
        System.Console.WriteLine($"Please input score for {player.Name}");
        player.Score6 = Convert.ToInt32(System.Console.ReadLine());
      }
      Console.Clear();
      System.Console.WriteLine($"Match at {this.Course.Name} has concluded, final Scores as follows:");
      foreach (Player player in PlayerList)
      {
        int Total = player.Score1 + player.Score2 + player.Score3 + player.Score4 + player.Score5 + player.Score6 - player.Handicap;
        System.Console.WriteLine($"{player.Name} H1 {player.Score1} H2 {player.Score2} H3 {player.Score3} H4 {player.Score4} H5 {player.Score5} H6 {player.Score6} TOTAL: {Total} ");
      }

    }
    public void RoundScore()
    {

      foreach (Player current in PlayerList)
      {
        System.Console.WriteLine($"Please input score for {current.Name}");
        current.Score1 = Convert.ToInt32(System.Console.ReadLine());
      }

    }

    public Match(Course course, List<Player> players)
    {
      Course = course;
      PlayerList = players;
    }
    public List<Player> PlayerList { get; set; }
    public Course Course { get; set; }
  }
}