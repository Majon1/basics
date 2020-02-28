using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> person = new List<string>();
      int oldest = 0;
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] pieces = input.Split(",");
        if (Convert.ToInt32(pieces[1]) > oldest)
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
        
      }
      Console.WriteLine("Age of the oldest: " + oldest);

    }
  }
}



