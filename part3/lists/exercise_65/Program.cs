﻿using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          int amount = list.Count;
        Console.WriteLine("In total: " + amount);
          break;
        }
        list.Add(input);
        
      }

    }
  }
}
