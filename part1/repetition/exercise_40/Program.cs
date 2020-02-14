using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int counter = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        string UserInput = Console.ReadLine();
        int number = Convert.ToInt32(UserInput);
        if (number == 0)
        {
          Console.WriteLine("Total sum of numbers: " + sum);
          Console.WriteLine("Total amount of numbers: " + counter);
          break;
        }
        else 
        {
          sum = sum + number;
          counter = counter + 1;
        }
      }
    }
  }
}
