using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
     int oldest = 2020;
     int length = 0;
     string longest = "";
     int age = 0;
     int nameLength = 0;

      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] pieces = input.Split(",");
        if (Convert.ToInt32(pieces[1]) < oldest)
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
        string word = pieces[0];
        length = word.Length;
        if (length > nameLength)
        {
          nameLength = length;
          longest = pieces[0];
        }
      }
      age = 2020 - oldest;
      Console.WriteLine("Longest name: " + longest);
      Console.WriteLine("Highest age: " + age);

    }
  }
}



