using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int number1, int number2, int number3)
    {
      return Math.Max(number1, Math.Max(number2, number3));
    }

  }
}
