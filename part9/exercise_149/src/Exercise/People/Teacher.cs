namespace Exercise
{ 
  public class Teacher : Person
  {
    public int salary { get; set; }
    public Teacher(string name, string adress, int salary) : base(name, adress)
    {
    this.salary = salary;
    }

    public override string ToString()
    {
       return base.ToString() + " salary " + this.salary + " per month"; 
    }
  }
}