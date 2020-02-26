namespace exercise_119
{
  public class Timer
  {
   private ClockHand hundredth;
   private ClockHand seconds;

   public Timer ()   
   {
       this.hundredth = new ClockHand(100);
       this.seconds = new ClockHand(60);
   }
   public void Advance()
   {
       this.hundredth.Advance();
       if (this.hundredth.value == 0)
       {
           this.seconds.Advance();
       }
   }
   public override string ToString()
   {
       return this.seconds + ":" + this.hundredth;
   }
  }
}  
