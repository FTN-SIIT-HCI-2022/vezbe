using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Order : INotifyPropertyChanged
    {
        public Order() { }

        public Order(string name, User user, Address address, Place place, List<Item> items, decimal total, DateTime dateTime, OrderState orderState)
        {
            Name = name;
            User = user;
            Address = address;
            Place = place;
            Items = items;
            Total = total;
            DateTime = dateTime;
            OrderState = orderState;
        }

        private string _name;
        public string Name { get
            { return _name; }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
                
                }    
        public User User { get; set; }
        public Address Address { get; set; }
        public Place Place { get; set; }
        public List<Item> Items { get; set; }   
        public decimal Total { get; set; }
        public DateTime DateTime { get; set; }
        public OrderState OrderState { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }


    public enum OrderState
    {
        WAIT, TAKE_ORDER, DELIVERED
    }
}
