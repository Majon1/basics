using System;

namespace exercise_30
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Give your percent [0 - 100]:");
            string percent = Console.ReadLine();
            int grading = Convert.ToInt32(percent);
            if (grading < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (grading <= 49)
            { 
              Console.WriteLine("Fail"); 
            }
            else if (grading <= 59)
            { 
            Console.WriteLine("Grade: 1"); 
            }
            else if (grading <= 69)
            { 
            Console.WriteLine("Grade: 2"); 
            }
            else if (grading <= 79)
            {
            Console.WriteLine("Grade: 3"); 
            }
            else if (grading <= 89)
            { 
            Console.WriteLine("Grade: 4"); 
            }
            else if (grading <= 100)
            { 
            Console.WriteLine("Grade: 5"); 
            }
            else if (grading > 100)
            { 
            Console.WriteLine("Outstanding!"); 
            }
        }
    }
}
