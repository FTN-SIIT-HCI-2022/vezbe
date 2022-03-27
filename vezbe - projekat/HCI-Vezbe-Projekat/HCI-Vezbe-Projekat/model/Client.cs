using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Client:User
    {
        public Client() : base() { }

        public Client(string username, string password,  string name, string surname, Address address, Role role) :
            base(username, password, name, surname, address, role) { 
            ActiveOrders = new List<Order>();  
            HistoryOrders = new List<Order>();  
        }   

        public List<Order> ActiveOrders { get; set; }
        public List<Order> HistoryOrders { get; set; }

    }
}
