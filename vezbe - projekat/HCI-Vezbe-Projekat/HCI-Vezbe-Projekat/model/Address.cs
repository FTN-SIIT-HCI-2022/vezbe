using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Address
    {
        public Address(string street, string city, string postal_code, string country)
        {
            Street = street;    
            City = city;    
            PostalCode = postal_code;   
            Country = country;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
