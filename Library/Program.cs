namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Story", 420);
            Author author1 = new Author("John Dou");
            book1.Author = new List<Author>();
            book1.Author.Add(author1);
            author1.ID = 1;
            author1.Books = new List<Book>();
            author1.Books.Add(book1);
            Publisher publisher = new Publisher();
            publisher.Name = "Vivat";
            Genre genre = new Genre();
            genre.Name = "Fantazy";
            publisher.Authors = new List<Author>();
            publisher.Authors.Add(author1);
            publisher.Books = new List<Book>();
            publisher.Books.Add(book1);
            book1.Genre = new List<Genre>();
            book1.Genre.Add(genre);
        }
    }
}