using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string number = Console.ReadLine();
      int numberpos = Convert.ToInt32(number);
      if (numberpos > 0)
        {
          Console.WriteLine("It is positive"); 
        }
      if (numberpos <= 0)
        {
          Console.WriteLine("It is not positive"); 
        } 
    }
  }
}
