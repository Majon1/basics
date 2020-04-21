namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;
    public Hand()
    {
      this.hand = new List<Card>();
    }
    public void Add(Card card)
    {
      if (!this.hand.Contains(card))
      {
        this.hand.Add(card);
      }
    }

    public void Print()
    {
      foreach (Card card in this.hand)
      {
        Console.WriteLine(card.ToString());
      }
    }

    public void Sort()
    {
      this.hand.Sort();
    }


    public int CompareTo(Hand hand)
    {
      int sumHand1 = 0;
      int sumHand2 = 0;
      foreach (Card card in this.hand)
      {
        sumHand1 += card.value;
      }
      foreach (Card card in hand.hand)
      {
        sumHand2 += card.value;
      }
      if (sumHand1 == sumHand2)
      {
        return 0;
      }
      else if (sumHand1 > sumHand2)
      {
        return 1;
      }
      else
      {
        return -1;
      }
    }
  }
}