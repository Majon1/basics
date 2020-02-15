using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      int i = 1;
      
      Console.WriteLine("How many times?");
      string UserInput = Console.ReadLine();
      int number = Convert.ToInt32(UserInput);
      
      PrintPhrase(i, number);
  
    }

    // Write your method here:
    public static void PrintPhrase(int i, int number)
    {
    
    
    while (i <= number)
      { 
      Console.WriteLine("In a hole in the ground there lived a method");
      i = i + 1;
      }
     }

    }
}

    

