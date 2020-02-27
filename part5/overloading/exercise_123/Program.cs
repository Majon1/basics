using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter(4);

      counter.Increase();
      counter.Decrease();
      counter.Increase(5);
      counter.Decrease(3);
      Console.WriteLine(counter);
    }
  }
}
