using System;
using System.Collections.Generic;
using System.Linq;

namespace GolfCard2.Models
{
  class Course
  {
    public Course CourseSelect(List<Course> courses)
    {
      Console.Clear();
      foreach (Course blah in courses)
      {
        System.Console.WriteLine($"{blah.ID} {blah.Name}");
      };
      try
      {

        int userSelection = Convert.ToInt32(Console.ReadLine());
        if (userSelection > courses.Count + 1)
        {
          System.Console.WriteLine("Invalid Selection");

          CourseSelect(courses);


        }
        return courses.Find(o => o.ID == userSelection);
      }
      catch
      {
        System.Console.WriteLine("Invalid Selection");
        CourseSelect(courses);
        return null;
      }
    }
    //Constructor
    public Course(int id, string courseName, string courseAddress, int h1num, int h1par, int h1dis)
    {
      ID = id;
      Name = courseName;
      Address = courseAddress;
      Hole1 = new Hole(h1num, h1par, h1dis);
    }
    #region Properties
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public Hole Hole1 { get; set; }
    public Hole Hole2 { get; set; }
    public Hole Hole3 { get; set; }
    public Hole Hole4 { get; set; }
    public Hole Hole5 { get; set; }
    public Hole Hole6 { get; set; }
    #endregion

  }

}