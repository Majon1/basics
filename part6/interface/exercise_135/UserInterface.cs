using System;

namespace exercise_135
{
    public class UserInterface
    {
        private JokeManager manager;

        public UserInterface(JokeManager manager)
        {
            this.manager = manager;
        }
        public void Start()
        {
            UserJokes();
        }
        public void Commands()
        {
            Console.WriteLine("Commands: ");
            Console.WriteLine("1 - add a joke");
            Console.WriteLine("2 - draw a joke");
            Console.WriteLine("3 - list jokes");
            Console.WriteLine("X - stop");
        }
        public void UserJokes()
        { 
            while(true)
            {   Commands();
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                Console.WriteLine("Write the joke to be added:");
                manager.AddJoke(Console.ReadLine());
            }
            if (userinput == "2")
            {
                Console.WriteLine("Drawing a joke:");
                Console.WriteLine(manager.DrawJoke());
            }
            if (userinput == "3")
            {
                Console.WriteLine("Printing the jokes:");
                manager.PrintJokes();
            }
            
            if (userinput == "X")
            {
                break;
            }
            }
        }
    }    
    }
