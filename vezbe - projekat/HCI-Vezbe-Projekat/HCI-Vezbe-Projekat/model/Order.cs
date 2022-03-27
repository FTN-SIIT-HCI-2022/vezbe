using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Order
    {
        public string Name { get; set; }    
        public User User { get; set; }
        public Address Address { get; set; }
        public Place Place { get; set; }
        public List<Item> Items { get; set; }   
        public decimal Total { get; set; }
        public DateTime DateTime { get; set; }
        public OrderState OrderState { get; set; }

    }


    public enum OrderState
    {

    }
}
