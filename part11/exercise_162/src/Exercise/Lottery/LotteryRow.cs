namespace Exercise
{
    using System;
    using System.Collections.Generic;

    public class LotteryRow
    {
        private List<int> numbers;

        public LotteryRow()
        {
            this.RandomizeNumbers();
        }

        public List<int> Numbers()
        {
            return this.numbers;
        }

        public bool ContainsNumber(int number)
        {

            if (this.numbers.Contains(number))
            {
                return true;
            }
            else
            {
                return false;
            }

            // Tests whether the number is already among the randomized numbers

        }

        public void RandomizeNumbers()
        {
            Random number = new Random();
            // initialize the list for numbers
            this.numbers = new List<int>();

            for (int i = 1; i <= 8; i++)
            {
                int randomNumber = number.Next(40);
               if(!(this.numbers.Contains(randomNumber)))
                {
                  this.numbers.Add(randomNumber);
                  i++;
                }
                
        
            } 
            this.numbers.Sort();
            // Implement the randomization of the numbers by using the method ContainsNumber() here
        }

    }
}