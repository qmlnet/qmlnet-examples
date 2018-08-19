using System.Collections.Generic;

namespace Features
{
    public class CollectionsModel
    {
        private readonly List<Contact> _contacts = new List<Contact>
        {
            new Contact
            {
                Name = "Paul Knopf",
                PhoneNumber = "525-525-52555"
            }
        };

        public bool AddContact(string name, string phoneNumber)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }
            
            _contacts.Add(new Contact
                {
                    Name = name,
                    PhoneNumber = phoneNumber
                });
            
            return true;
        }

        public void RemoveContact(int index)
        {
            _contacts.RemoveAt(index);
        }

        public List<Contact> Contacts
        {
            get => _contacts;
        }

        public class Contact
        {
            public string Name { get; set; }
            
            public string PhoneNumber { get; set; }
        }
    }
}