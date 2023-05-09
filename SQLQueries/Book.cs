namespace SQLQueries
{
    public class Book
    {
        public int BookId {  get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int BookCount { get; set; }
        public Author Author { get; set; }
        public Order Order { get; set; }
        public Book() { }
    }
}
