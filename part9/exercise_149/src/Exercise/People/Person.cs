namespace Exercise
{
  using System;
  public class Person
  {
    public string name { get; set; }
    public string adress { get; set; }

    public Person(string name, string adress)
    {
      this.name = name;
      this.adress = adress;
    }

    public override string ToString()
    {
      return this.name + ", " + this.adress;
    } 
  }
}