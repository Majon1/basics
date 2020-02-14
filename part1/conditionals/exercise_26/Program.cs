using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string age = Console.ReadLine();
      int number = Convert.ToInt32(age);
      if (number < 1900)
        {
          Console.WriteLine("You're old"); 
        }
    }
  }
}
