using System;
using System.Collections.Generic;
using GolfCard2.Models;
namespace GolfCard2
{
  class Program
  {
    static void Main(string[] args)
    {
      Int32 NumberPlayers = 0;
      Int32 NumberPlayers2 = 0;
      Player Player1 = null;
      Player Player2 = null;
      Player Player3 = null;
      Player Player4 = null;
      List<Player> PlayersPlaying = new List<Player>();
      Console.WriteLine("Hello World!");
      Course myCourse1 = new Course(1, "GreenGolf", "1212 Greenway Dr", 1, 4, 256);
      Course myCourse2 = new Course(2, "Forbidden Acres", "6006 BadDrive Way", 1, 1, 320);
      List<Course> CoursesToSelect = new List<Course> { myCourse1, myCourse2 };
      Course CoursePlaying = myCourse1.CourseSelect(CoursesToSelect);
      Console.Clear();
      System.Console.WriteLine($"Now Playing {CoursePlaying.Name}");
      #region old stuff
      //   switch (NumberPlayers)
      //   {
      //     case 4:
      //       PlayersPlaying.Add(Player1);
      //       PlayersPlaying.Add(Player2);
      //       PlayersPlaying.Add(Player3);
      //       PlayersPlaying.Add(Player4);
      //       break;
      //     case 3:
      //   PlayersPlaying.Add(Player1);
      //   PlayersPlaying.Add(Player2);
      //       PlayersPlaying.Add(Player3);
      //       break;
      //     case 2:
      //       PlayersPlaying.Add(Player1);
      //       PlayersPlaying.Add(Player2);
      //       break;
      //     case 1:
      //       PlayersPlaying.Add(Player1);
      //       break;
      //     default:
      //       break;
      //   }
      #endregion

      NumberOfPlayers();
      AssignPlayers();

      Match ThisMatch = new Match(CoursePlaying, PlayersPlaying);
      ThisMatch.StartMatch();









      void AssignPlayers()
      {
        while (NumberPlayers2 > 0)
        {
          switch (NumberPlayers)
          {

            case 4:
              Player4 = new Player(EnterName(), EnterHandi());
              //Player4.Handicap = EnterHandi();
              PlayersPlaying.Add(Player4);
              NumberPlayers2--;
              Console.Clear();
              break;
            case 3:
              Player3 = new Player(EnterName(), EnterHandi());
              PlayersPlaying.Add(Player3);
              NumberPlayers2--;
              Console.Clear();
              break;
            case 2:
              Player2 = new Player(EnterName(), EnterHandi());
              PlayersPlaying.Add(Player2);
              NumberPlayers2--;
              Console.Clear();
              break;
            case 1:
              Player1 = new Player(EnterName(), EnterHandi());
              PlayersPlaying.Add(Player1);
              NumberPlayers2--;
              Console.Clear();
              break;

            default:
              break;
          }
        }
      }

      int EnterHandi()
      {
        System.Console.WriteLine("Please Input Handicap");
        int handi = Convert.ToInt32(Console.ReadLine());
        return handi;
      }
      string EnterName()
      {

        System.Console.WriteLine("Please Input Player Name");
        string name = Convert.ToString(Console.ReadLine());
        return name;
      }

      void NumberOfPlayers()
      {
        System.Console.WriteLine("How many Players? (1 to 4)");
        try
        {
          NumberPlayers = Convert.ToInt32(Console.ReadLine());
          NumberPlayers2 = NumberPlayers;
          if (NumberPlayers2 >= 1 && NumberPlayers2 < 5)
          {

          }
          else
          {
            System.Console.WriteLine("Invalid Selection");
            NumberOfPlayers();
          }
        }
        catch
        {
          System.Console.WriteLine("Invalid Selection");
          NumberOfPlayers();
        }
      }


    }
  }
}
