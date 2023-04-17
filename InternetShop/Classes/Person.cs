namespace InternetShop
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Person (int id, string firstname, string lastname, int age, 
            string email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Email = email;
        }

    }
}
