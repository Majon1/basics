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
      string name = pieces[0];
      int age = Convert.ToInt32(pieces[1]);
      
      for (int age)
      {
        if (number < age)
        {
          Console.WriteLine("Name of the oldest: " + name);
        }
     
      }
    }
  }}}




