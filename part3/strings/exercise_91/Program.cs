using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
     int count = 0;
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] pieces = input.Split(",");
        count = Convert.ToInt32(pieces[1]);
        
      }
      Console.WriteLine("Name of the oldest: " + pieces[0]);

    }
  }
}



