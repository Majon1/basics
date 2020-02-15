using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      
      // Call your method here:
    int number = Convert.ToInt32(5);
    PrintUntilNumber(number);

    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
    int i = 1;
    while (i <= number)
    {
      Console.WriteLine(i);
      i++;
    }
    }
  }
}
