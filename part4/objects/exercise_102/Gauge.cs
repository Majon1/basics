using System;

namespace exercise_102
{
    public class Gauge
    {
      public int value { get; set; }

      public Gauge()
      {
          this.value = 0;
      }
      public void Increase() //increase by 1, not beyond 5
      {
          if (this.value < 5)
          {
              this.value++;
          }
      }
      public void Decrease() //decrease by 1, not beyond 0
      {
          if (this.value > 0)
          {
              this.value--;
          }
      }
      public bool Full() //true if value 5
      {
          if (this.value == 5)
          {
              return true;
          }
          else
          {
              return false;
          }
      }
    }
}