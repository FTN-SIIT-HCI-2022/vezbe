using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Deliverer : User 
    {
        public Deliverer() : base(){}

        public Deliverer(string username, string name, string surname, Address address, bool active) :
            base(username, name, surname, address )
        {
            Active = active; 
            ActiveOrders = new List<Order>();
            WaitingOrders = new List<Order>();
            HistoryOrders = new List<Order>();
        }

        public List<Order> ActiveOrders { get; set; } //narudzbe koje su stanju dostave   
        public List<Order> WaitingOrders { get; set; }  //narudzbe koje tek treba da preuzme 
        public List<Order> HistoryOrders { get; set; } //narudzbe koje je dostavio

        public bool Active { get; set; }  //da li trenutno radi ili ne 


        public void AddAcitiveOrder(Order o)
        {
            ActiveOrders.Add(o);
        }

        public void AddWaitingOrder(Order o)
        {
            WaitingOrders.Add(o);
        }


    }
}
