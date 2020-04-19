namespace Exercise
{
  using System.Linq;
  using System;
  using System.Collections.Generic;
  public class ChangeHistory
  {
    private List<int> history;

    public ChangeHistory()
    {
      this.history = new List<int>();
    }

    public void Add(int status)
    {
      this.history.Add(status);
    }

    public void Clear()
    {
      this.history.Clear();
    }

    public int MaxValue()
    { 
      int max = 0;
      if (this.history.Count > 0)
      {
        max = this.history.Max();
      }
      return max;
    }

    public int MinValue()
    {
      int min = 0;
      if (this.history.Count > 0)
      {
       min = this.history.Min();
      }
      return min;
    }

    public override string ToString()
    {
      int lastStatus = this.history[this.history.Count -1];
      return "Current: " + lastStatus + " Min: " + MinValue() + " Max: " + MaxValue();
    }
  }
}
