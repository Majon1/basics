namespace Exercise
{
  public class Furniture : IPackable
  {
    public string furnitureType;
    public string color;
    public int weight;

    public Furniture(string furnitureType, string color, int weight) //furniture, color, weight
    {
      this.furnitureType = furnitureType;
      this.color = color;
      this.weight = weight;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.color + " " + this.furnitureType + " - weight " + this.weight + " kg";
    }
  }
}