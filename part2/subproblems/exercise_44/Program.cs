using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
      if (number1 > number2)
      {
        Console.WriteLine(number1 + " is greater than " + number2 + ".");
      }
      else if (number1 < number2)
      {
        Console.WriteLine(number1 + " is less than " + number2 + ".");
      }
      else 
      {
        Console.WriteLine(number1 + " is equal to " + number2 + ".");
      }
    } 
  }
}
