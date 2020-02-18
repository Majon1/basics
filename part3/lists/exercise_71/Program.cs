using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          Console.WriteLine("Search for?");
          int find = Convert.ToInt32(Console.ReadLine());
          if (list.Contains(find))
          public int FindIndex (find match);
          Console.WriteLine(find + " is at index " + list.FindIndex(find)); 
          break;
        }
        list.Add(input);
      }

    }
  }
}
