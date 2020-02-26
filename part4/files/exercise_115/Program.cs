using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
      string input = Console.ReadLine();

      if (input == "end")
        {
          break;
        }
         int userinput = Convert.ToInt32(input);
         int cubed = userinput * userinput * userinput;
         Console.WriteLine(cubed);
      }  
    }
  }
}
