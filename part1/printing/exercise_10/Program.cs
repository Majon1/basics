using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but i need som information.\n" + "Give a name for main character:");
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();
            Console.WriteLine("Here is the story:\n" + "Once upon a time there was a " + profession + " called " + name);
            Console.WriteLine("On her way to work, " + name + " often pondered what being " + profession + " meant to them.");
            Console.WriteLine("When you work as a " + profession + " you meet interesting people.");
            Console.WriteLine(name + "enjoys their work as " + profession + ", The end.");
        }
    }
}
