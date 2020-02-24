using System;

namespace exercise_113
{
    public class Book
    {
        public string title { get; set; }
        public int pages { get; set; }
        public int publicationYear { get; set; }

        public Book(string title, int pages, int publicationYear)
        {
            this.title = title;
            this.pages = pages;
            this.publicationYear = publicationYear;
        }

        public override string ToString()
        {
            return this.title + ", " + this.pages + " pages, " + this.publicationYear;
        }
        
        
    }
}