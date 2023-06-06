namespace LibraryMVC.Models
{
    public sealed record Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int BookCount { get; set; }
        public int AuthorId { get; set; }
    }
}
