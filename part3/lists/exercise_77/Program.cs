using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can try your method here if you want
      List<string> strings = new List<string>();
      strings.Add("First");
      strings.Add("Second");
      strings.Add("Third");
      //int i = strings.Count;
      strings.ForEach(Console.WriteLine);
      RemoveLast(strings);
      strings.ForEach(Console.WriteLine);

    }
    public static void RemoveLast(List<string> strings)
    { 
      foreach (string value in strings)
      {
        Console.WriteLine(value);
      }
      
      //strings.RemoveAt([i - 1]);
      //Console.WriteLine([index]);
    }
  }
}


