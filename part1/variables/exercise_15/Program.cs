using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string message2 = Console.ReadLine();
      int intm = Convert.ToInt32(message2);
      Console.WriteLine("Give a double:");
      string doub = Console.ReadLine();
      double doub2 = Convert.ToDouble(doub);
      Console.WriteLine("Give a boolean:");
      string message3 = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(message3);
      Console.WriteLine("Your string: " + message);
      Console.WriteLine("Your integer: " + message2);
      Console.WriteLine("Your double: " + doub2);
      Console.WriteLine("Your boolean: " + booleanValue);
    }
  }
}
