namespace Exercise
{
  using System;
  public class Person
  {

    public string name { get; }
    public int age { get; }

    public Person(string name, int age)
    {
      if (name == null ||  name.Length == 0 || name.Length > 40)
      {
        throw new ArgumentException("Name can't be null or over 40 characters.");
      }
      if (age <= 0 || age >= 120)
      {
        throw new ArgumentException("Age must be between 0-120 years");
      }
      this.name = name;
      this.age = age;
    }
  }
}