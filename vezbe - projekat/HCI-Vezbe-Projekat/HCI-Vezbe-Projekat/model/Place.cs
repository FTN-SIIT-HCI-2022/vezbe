using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public abstract class Place
    {
        public Place()
        {
        }
        public Place(string name, string description, Address address)
        {
            Name = name;
            Description = description;
            Address = address;
        }

        //radnja koja moze da bude prodavnica ili restoran, klijenti iz njih mogu da narucuju
        public string Name { get; set; }
        public string Description { get; set; } 
        public Address Address { get; set; }

        //TO DO: lista radnog vremena 
        // dan, pocetak, kraj
    }
}
