namespace EntityFramework.Models
{
    public sealed record Customer : EntityWithId
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
