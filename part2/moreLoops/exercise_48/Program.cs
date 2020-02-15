using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:");
      int sum = 0;
      double numbers = 0;
      int odd = 0;
      int even = 0;
      
      while (true)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == -1)
      {
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Numbers: " + numbers);
        double average = (sum) / numbers;
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
        break;
      }
      else if (number % 2 == 0)
      {
        sum = sum + number;
        numbers = numbers + 1;
        even = even +1;
 
      }
      else if (number % 2 != 0)
      {
        sum = sum + number;
        numbers = numbers + 1;
        odd = odd + 1;
      }
        
      }
      }
    }
  }

 
    
