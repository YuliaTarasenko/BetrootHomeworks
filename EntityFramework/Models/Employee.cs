namespace EntityFramework.Models
{
    public sealed record Employee : EntityWithId
    {
        public string Name { get; set; }
        public ICollection<Order> Order { get; set; } 
    }
}
