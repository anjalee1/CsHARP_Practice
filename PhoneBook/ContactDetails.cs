using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class ContactDetails
    {
        private List<ContactDetails> _contacts { get; set; } 


        
        public ContactDetails(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
