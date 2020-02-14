using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
     // Write your code here:
      Console.WriteLine("Give a number:");
      string year = Console.ReadLine();
      int number = Convert.ToInt32(year);
      if (number == 1984)
        {
          Console.WriteLine("Orwell"); 
        }
    }
  }
}
