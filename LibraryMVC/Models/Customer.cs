﻿namespace LibraryMVC.Models
{
    public sealed record Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
