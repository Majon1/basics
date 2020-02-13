using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine("Give the second number!");
      string userIn = Console.ReadLine();
      int intV = Convert.ToInt32(userIn);
      Console.WriteLine(intValue + " * " + intV + " = " + (intValue * intV));
    }
  }
}
