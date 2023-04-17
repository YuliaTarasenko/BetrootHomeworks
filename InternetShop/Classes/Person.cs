namespace InternetShop
{
    internal abstract class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Person (int personId, string firstname, string lastname, int age, 
            string email, string phoneNumber, string address)
        {
            PersonId = personId;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

    }
}
