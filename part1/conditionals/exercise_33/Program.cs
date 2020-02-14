using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string UserInput = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string UserIn = Console.ReadLine();
      if (UserInput == UserIn)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }
    }
  }
}
