using System;

namespace exercise_97
{
    private class Whistle
    {
        private string sound;
        public Whistle(string whistleSound)
        {   
         this.sound = whistleSound;
        }
    
        public void Sound()
        {
            Console.WriteLine(this.sound);
        } 
    }
}
