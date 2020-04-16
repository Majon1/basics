namespace Exercise
{
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
      if (this.history.Count > 0)
      {
      int max = history.Max();
      }
      else 
      {
        return 0;
      }
    }

    public int MinValue()
    {
      return 0;
    }

    public override string ToString()
    {
      return "Current: " + base.ToString() + " Min: " + " Max: ";
    }
  }
}
