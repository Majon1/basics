using System;
using System.Collections.Generic;

namespace exercise_68
{
  class Program
  {
    public static void Main(string[] args)
    { int index = 0;
      List<int> list = new List<int>();
      while (true)
      { 
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          for (index = 0; index < list.Count; index++)
          Console.WriteLine(list[index]);
          break;
        }
        list.Add(input);
        index++;
      }

    }
  }
}
