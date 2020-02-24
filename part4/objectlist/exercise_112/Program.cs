using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<TelevisionProgram> list = new List<TelevisionProgram>();
      while (true)
      {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }

        Console.Write("Duration: ");
        int duration = Convert.ToInt32(Console.ReadLine());
     
      list.Add(new TelevisionProgram (name, duration));

      }
      Console.WriteLine();
      Console.Write("Program's maximum duration? ");
      int maxtime = Convert.ToInt32(Console.ReadLine());
  
    foreach (TelevisionProgram program in list)
    {
      if (program.duration <= maxtime)
      {
        Console.WriteLine(program.name + ", " + program.duration + " minutes");
      }
    }
  }
  }
}




