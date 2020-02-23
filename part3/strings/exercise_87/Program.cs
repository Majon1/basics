using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
      string userinput = Console.ReadLine();
      if (userinput == "")
      {
        break;
      }
      }
      string[] pieces = userinput.Split(" ");
      
      for (int i = 0; i < pieces.Length; i++)
      {
      if (userinput.Contains("av"))
      {
        Console.WriteLine(pieces);
      }
      }
    }
  }
}

