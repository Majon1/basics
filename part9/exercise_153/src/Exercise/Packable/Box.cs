using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Box : IPackable
  {
    private List<IPackable> list;
    private int maxCapacity;
    public Box(int maxCapacity)
    {
      this.maxCapacity = maxCapacity;
      this.list = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
      if (Weight() + item.Weight() <= this.maxCapacity)
      {
        list.Add(item);
      }
    }

    public int Weight()
    {
      int weightSum = 0;
      foreach (IPackable item in list)
      {
        weightSum = weightSum + item.Weight();
      }
      return weightSum;
    }

    public override string ToString()
    {
      return list.Count + " items, total weight " + Weight() + " kg";
    }
  }
}