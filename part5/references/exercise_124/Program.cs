using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      Names john = new Names ("john", 2);
      john.GrowOlder();

      john = null;
      john.GrowOlder();
      
    }
  }
}
