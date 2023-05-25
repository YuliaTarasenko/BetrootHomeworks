namespace EntityFramework
{
    public sealed record Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public ICollection<Order> Order { get; } = new List<Order>();
    }
}
