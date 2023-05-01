using System;
using System.IO;
using System.Text.Json;

namespace Hometask7
{
    public class PhoneBook
    {
        public List<Person> Persons { get; set; }
        public PhoneBook()
        {
            Persons = new List<Person>();
        }

        public void AddContact(Person person)
        {
            Persons.Add(person);
            Sort();
        }

        public void RemoveContact(Person person)
        {
            Persons.Remove(person);
        }

        public void PrintInfo()
        {
            foreach (Person person in Persons) 
            {
                Console.WriteLine($"{person.FirstName}\t {person.LastName}\t {person.PhoneNumber}");
            }
        }

        public void Serialize()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(Persons, options);
            File.WriteAllText("../../../contacts.json", json);
        }

        public List<Person> Deserialize()
        {
            string json = File.ReadAllText("../../../contacts.json");
            List<Person> contacts = JsonSerializer.Deserialize<List<Person>>(json);
            return contacts;
        }

        public List<Person> SearchContacts( string searchTerm)
        {
            var contacts = Persons;
            return contacts
                .Where(c => c.FirstName.Contains(searchTerm) ||
                            c.LastName.Contains(searchTerm) ||
                            c.PhoneNumber.Contains(searchTerm))
                .ToList();
        }

        public Person BinarySearchByName(string firstName)
        {
            var contacts = Persons;
            int min = 0;
            int max = contacts.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                int result = firstName.CompareTo(contacts[mid].FirstName);
                if (result == 0)
                {
                    return contacts[mid];
                }
                else if (result < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return null;
        }

        private void Sort()
        {
            if (Persons.Count > 1)
            {
                Persons = Persons.OrderBy(c => c.LastName).
                    ThenBy(c => c.FirstName).ThenBy(c => c.PhoneNumber).ToList();
            }
        }
    }
}