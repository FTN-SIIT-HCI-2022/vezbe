using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Offer : INotifyPropertyChanged
    {
        // ponuda odnosi se na listu itema i cenu 

        public Offer() { }

        public Offer(List<Item> items, string name, double price, string d) { 
            Items = items;
            Name = name;
            Price = price;
            Description = d;
        }

        

        public List<Item> Items { get; set; }

        private string _name;
        private double _price;
       public string Description { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public string Name {
            get { return _name;  }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }    
        public double Price {
            get { return _price; }
            set
            {
                if(value != _price)
                {
                    _price = value;
                    OnPropertyChanged("Price");
                }
            }
                
        }
    }



}
