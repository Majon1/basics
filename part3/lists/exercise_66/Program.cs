﻿using System;
using System.Collections.Generic;

namespace exercise_66
{
  class Program
  {
    public static void Main(string[] args)
    { int i = 0;
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          Console.WriteLine(list[i - 1]);
          break;
        }
        list.Add(input);
        i++;
      }


    }
  }
}
