using System;

namespace exercise_124
{
    public class Names
    {
        public string name { get; set; }
        public int age { get; set; }

        public Names (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GrowOlder()
        {
            this.age = this.age + 1;
        }
    }
}