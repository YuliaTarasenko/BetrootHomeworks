namespace EntityFramework.Models
{
    public sealed record Employee : EntityWithId
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; } 
    }
}
