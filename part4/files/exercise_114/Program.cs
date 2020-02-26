using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {   int amount = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                amount++;  
            }
            Console.WriteLine(amount);
            }
        }
    }

