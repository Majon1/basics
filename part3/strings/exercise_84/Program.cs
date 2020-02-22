using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a string: ");
      string userinput = Console.ReadLine();
      if (userinput == "true")
      {
        Console.Write("You got it right!");
      }
      else
      {
        Console.Write("Try again!");
      }
      Console.WriteLine("");

    }
  }
}

