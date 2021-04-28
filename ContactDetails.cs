using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ContactDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }

        //to check existing details
        public override bool Equals(object obj)
        {
            ContactDetails contact = obj as ContactDetails;
            if (obj == null)
                return false;
            return this.FirstName.Equals(contact.FirstName) && this.LastName.Equals(contact.LastName);
        }
    }
    
}

