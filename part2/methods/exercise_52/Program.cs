using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int number = Convert.ToInt32(5);
      PrintFromNumberToOne (number);
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number)
    {
    int i = 1;
    while (i <= number)
    {
      Console.WriteLine(number);
      number = number - 1;
    }
    }
  }
}
