namespace Exercise
{
  public class LicensePlate
  {
    public string liNumber { get; }
    private string country;

    public LicensePlate(string country, string liNumber)
    {
      this.liNumber = liNumber;
      this.country = country;
    }


    public override string ToString()
    {
      return country + " " + liNumber;
    }

    public override bool Equals(object compared)
    {
       if (this == compared)
      {
        return true;
      }
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
      return false;
      }
     LicensePlate comparedNumber = (LicensePlate)compared;
     return this.country == comparedNumber.country && this.liNumber == comparedNumber.liNumber;
    }

    public override int GetHashCode()
    {
    return this.country.GetHashCode() + this.liNumber.GetHashCode();
    }
  }
}