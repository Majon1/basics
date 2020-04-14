using System;
using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    private Dictionary<string, int> dictionary; 
    public IOU()
    {
      this.dictionary = new Dictionary<string, int>();
    }
    public void ChangeDebt(string toWhom, int amount)
    {
      if (this.dictionary.ContainsKey(toWhom))
      {
        int newDebt = this.dictionary[toWhom] + amount;
        if  (newDebt > 0)
        {
          this.dictionary[toWhom] = newDebt;
        }
        else
        {
          this.dictionary[toWhom] = 0;
        }
      }
      else if (amount > 0)
      {
        this.dictionary[toWhom] = amount;
      }
      else
      {
        this.dictionary[toWhom] = 0;
      }
    }

    public int HowMuchDoIOweTo(string toWhom)
    {
      if (this.dictionary.ContainsKey(toWhom))
      {
        return this.dictionary[toWhom];
      }
      else
      {
      return 0;
      }
    }
  }
}
