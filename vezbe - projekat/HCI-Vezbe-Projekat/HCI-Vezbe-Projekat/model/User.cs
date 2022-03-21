using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public abstract class User
    {

        public User() { }
        public User(string user_name, string name, string surname, Address address)
        {
            UserName = user_name;
            Name = name;
            Surname = surname;
            Address = address;

        }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }

    }
}

    