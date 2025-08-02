namespace Library_Management_System.Models
{
    public class Book
    {
       
        public Author Author { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public int PublicationYear { get; set; }

        public DateTime DateLastReturned { get; set; }
        public bool IsAvailable { get; set; }

        public BookGenre Genre { get; set; }
    }
    public enum BookGenre
    {
        Fiction,
        NonFiction,
        Mystery,
        ScienceFiction,
        Biography,
        History,
        Children,
        Fantasy,
        Romance,
        Thriller,
        Historical,
        Classic,
        Drama,
        Adventure,
        Other
    }
}

