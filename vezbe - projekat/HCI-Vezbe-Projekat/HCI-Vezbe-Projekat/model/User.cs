using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class User
    {

        public User() { }
        public User(string user_name, string password, string name, string surname, Address address, Role role)
        {
            UserName = user_name;
            Password = password;
            Name = name;
            Surname = surname;
            Address = address;
            Role = role;

        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }

    public enum Role
    {
        MANAGER, CLIENT, DELIVERER
    }
}

    