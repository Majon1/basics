namespace Exercise
{ using System;
  using System.Collections.Generic;
  public class Herd : IMovable
  {
    private List<IMovable> herd;

    public Herd()
    {
      this.herd = new List<IMovable>();
    }

    public void AddToHerd(IMovable movable)
    {
      this.herd.Add(movable);
    }

    public void Move(int dx, int dy)
    {
      foreach (IMovable movable in herd)
      {
        movable.Move(dx,dy);
      }
    }

    public override string ToString()
    {
      string position = "";
      foreach (IMovable movable in herd)
      {
        position += movable.ToString() + "\n";
      }
      return position;
    }
  }
}