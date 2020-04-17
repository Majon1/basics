namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    public int capacity { get; set; }
    public BoxWithMaxWeight(string name, int capacity) : base()
    {
      this.capacity = capacity;
    }

    public override void Add(Item item)
    {
     if (base.item < this.capacity)
     {
       Add;
     }
     else
     {
       return 0;
     }
    }

    public override bool IsInBox(Item item)
    {
      return false;
    }
  }
}