using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string nr = Console.ReadLine();
      int first = Convert.ToInt32(nr);
      Console.WriteLine("Give the second number!");
      string nr2 = Console.ReadLine();
      int second = Convert.ToInt32(nr2);
      if (first > second)
        { 
         Console.WriteLine("The larger number is " + first + "!");
        }
      if (first < second)
        { 
          Console.WriteLine("The larger number is " + second + "!");
        } 
      if (first == second)
        {
          Console.WriteLine("They are equal!");
        }
    }
  }
}
