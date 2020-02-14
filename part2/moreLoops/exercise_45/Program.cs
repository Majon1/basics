using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int i = 0;
      int UserInput = Convert.ToInt32(Console.ReadLine());
      while (i <= UserInput)
      {
        Console.WriteLine(i);
        i++;
      }
    }
  }
}
