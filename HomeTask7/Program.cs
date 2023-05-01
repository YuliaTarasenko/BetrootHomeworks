namespace Hometask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddContact(new Person("Sara", "Kol", "555-54-52"));
            phoneBook.AddContact(new Person("Alex", "Dinn", "855-54-52"));
            phoneBook.AddContact(new Person("John", "Big", "951-54-52"));
            phoneBook.AddContact(new Person("Sam", "Kol", "455-54-52"));
            phoneBook.AddContact(new Person("White", "Leo", "321-54-52"));

            phoneBook.Serialize();
            phoneBook.AddContact(new Person("Ben", "Big", "555-55-55"));
            phoneBook.Serialize();

            var phoneBookFromFile = phoneBook.Deserialize();
            foreach (Person person in phoneBookFromFile)
            {
                Console.WriteLine($"{person.FirstName}\t {person.LastName}\t {person.PhoneNumber}");
            }
            //phoneBook.PrintInfo();

            //Console.WriteLine("Enter search term:");
            //string searchTerm = Console.ReadLine();

            //List<Person> searchResults = phoneBook.SearchContacts(searchTerm);

            //if (searchResults.Count > 0)
            //{
            //    Console.WriteLine($"Found {searchResults.Count} contact(s) matching '{searchTerm}':");
            //    foreach (Person contact in searchResults)
            //    {
            //        Console.WriteLine($"- {contact.FirstName} {contact.LastName}, {contact.PhoneNumber}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"No contacts found matching '{searchTerm}'.");
            //}

            //Person binarySearch = phoneBook.BinarySearchByName("Sam");
            //if (binarySearch != null)
            //{
            //    Console.WriteLine($"Found contact: {binarySearch.FirstName} {binarySearch.LastName} {binarySearch.PhoneNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Contact not found.");
            //}
        }
    }
}