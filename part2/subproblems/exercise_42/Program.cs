using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
      double squareRoot = Math.Sqrt((number1 + number2));
      Console.WriteLine(squareRoot);
    }
  }
}
