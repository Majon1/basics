using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
      while (true)
      {
       Console.WriteLine("Give a number:");
       string UserInput = Console.ReadLine();
       int number = Convert.ToInt32(UserInput);
       if (number == 0)
       {
         Console.WriteLine("Total amount of numbers: " + sum);
         break;
       } 
       else
       {
         sum = sum + 1;
       }
      

      }

    }
  }
}
