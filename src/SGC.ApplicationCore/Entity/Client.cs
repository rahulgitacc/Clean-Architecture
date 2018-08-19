using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
    public class Client
    {
        public Client()
        {

        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public Address Address { get; set; }
        public ICollection<CustomerService> CustomerServices { get; set; }
    }
}
