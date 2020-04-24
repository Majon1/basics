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

            return this.numbers.Contains(number);

            // Tests whether the number is already among the randomized numbers

        }

        public void RandomizeNumbers()
        {
            // initialize the list for numbers
            this.numbers = new List<int>();
            Random number = new Random();

            while (this.numbers.Count < 7)
            {
                int lottery = number.Next(1, 41);
                if (!ContainsNumber(lottery))
                {
                    this.numbers.Add(lottery);
                }


            }
            this.numbers.Sort();
            // Implement the randomization of the numbers by using the method ContainsNumber() here
        }

    }
}