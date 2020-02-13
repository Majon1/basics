using System;

namespace exercise_22
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
      Console.WriteLine("Give the third number!");
      string userI = Console.ReadLine();
      int intVa = Convert.ToInt32(userI);
      double average = (intValue + intV + intVa) / 3.0; 
      Console.WriteLine("The average is " + average); 

    }
  }
}
