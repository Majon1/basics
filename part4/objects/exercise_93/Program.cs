using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account secondAccount = new Account("second account", 100.00);
      secondAccount.Deposit(20);
      Console.WriteLine(secondAccount.balance);
    }
  }
}



