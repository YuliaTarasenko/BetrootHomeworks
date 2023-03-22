namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Genre genre = new Genre();
            genre.Name = "Genre 1";
            book.Name = "Test";
            book.Pages = 123;
            Author author = new Author();
            author.Name = "Author 1";
            Publisher publisher = new Publisher();
            publisher.Name = "Publisher 1";
            //author.Publisher.Add(publisher);
            //author.Books.Add(book);
            //publisher.Authors.Add(author);
            //publisher.Books.Add(book);
            //publisher.Genres.Add(genre);
            book.Genre = genre;
            book.Author = author;
            book.Publisher = publisher;
            book.Print();
          
        }
    }
}