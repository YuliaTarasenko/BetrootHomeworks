namespace LibraryMVC.Models
{
    public sealed record Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
