namespace exercise_125
{
  public class HealthStation
  {
    public int weighings { get; private set; }

    public HealthStation()
    {
      this.weighings = 0;
    }
    // Create a constructor here, if needed

    public int Weigh(Person person)
    {
      weighings++;
      return person.weight;
      // return the weight of the person passed as the parameter
      // incrase weighings
    }

    public void Feed(Person person)
    {
      // Increse the weight of the person with one kilogram
      person.weight++;
    }
  }
}