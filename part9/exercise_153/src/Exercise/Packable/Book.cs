namespace Exercise
{
  public class Book : IPackable
  {
    public string author;
    public string book;
    public int year;
    public int weight;

    public Book(string author, string book, int year)  //author, name of book, publication year
    {
      this.author = author;
      this.book = book;
      this.year = year;
      this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }
    public override string ToString()
    {
      return this.author + ": " + this.book + " (" + this.year + ")";
    }
  }
}