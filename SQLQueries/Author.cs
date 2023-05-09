namespace SQLQueries
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Book Book { get; set; }
        public Author() { }
    }
}
