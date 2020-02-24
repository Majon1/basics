using System;

namespace exercise_100
{
    public class Debt
    {
        private double balance;
        private double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
        this.balance = initialBalance;
        this.interestRate = initialInterestRate;
        }

        public void PrintBalance() //current balance
        {
            Console.WriteLine(this.balance);
        }

        public void WaitOneYear() //grows debt amount
        {
            this.balance = this.balance * this.interestRate;
        }
    }
}