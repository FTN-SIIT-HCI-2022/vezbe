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

        public Client(string username, string name, string surname, Address address) : base(username, name, surname, address) { 
            ActiveOrders = new List<Order>();  
            HistoryOrders = new List<Order>();  
        }   

        public List<Order> ActiveOrders { get; set; }
        public List<Order> HistoryOrders { get; set; }

    }
}
