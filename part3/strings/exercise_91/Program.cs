using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
     
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] pieces = input.Split(",");
        string nameLength = pieces[0].Length;
        
      }
      Console.WriteLine("Age of the oldest: " + nameLength);

    }
  }
}



