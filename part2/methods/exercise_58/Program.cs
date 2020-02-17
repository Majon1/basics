using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int number1, int number2)
    {
    return Math.Min(number1, number2);
    }
  
  }
}
