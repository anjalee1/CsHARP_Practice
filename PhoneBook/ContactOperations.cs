using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PhoneBook
{
    class ContactOperations
    {
        private List<ContactDetails> _contacts { get; set; } = new List<ContactDetails>();
        private void DisplayContactDetails(ContactDetails contact)
        {
            Console.WriteLine($"Contact: {contact.Name},{contact.Number}");

        }
        private void DisplayContactsDetails(List<ContactDetails> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }

        }

        public void AddContact(ContactDetails contact)
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact NOT FOUND");
            }
            else
            {
                DisplayContactDetails(contact);
            }

        }

        public void DisplayAllContact()
        {
            DisplayContactsDetails(_contacts);
        }

        public void DisplayMatchContact(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c=>c.Name.Contains( searchPhrase)).ToList();
            
                DisplayContactsDetails(matchingContacts);
            
        }
    }
}
