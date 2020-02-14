using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
      {
        Console.WriteLine("Give a number:");
        string answer = Console.ReadLine();
        int number = Convert.ToInt32(answer);
        if (number == 42)
        {
          break;
        }
      }
    }
  }
}
