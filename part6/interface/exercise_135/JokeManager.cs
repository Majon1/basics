using System;
using System.Collections.Generic;

namespace exercise_135
{
    public class JokeManager
    {
        private List<string> jokes;
        public JokeManager()
        {
            this.jokes = new List<string>();
        }
        public void AddJoke(string joke)
        {
            jokes.Add(joke);
        }
        public string DrawJoke()
        {
            if (this.jokes.Count == 0)
            {
                return ("Jokes are in short supply.");
            }
            else 
            {
                Random draw = new Random();
                int index = draw.Next(jokes.Count);
                return jokes[index];
            }
        }
        public void PrintJokes()
        {
            jokes.ForEach(Console.WriteLine); 
        }
    }
}
