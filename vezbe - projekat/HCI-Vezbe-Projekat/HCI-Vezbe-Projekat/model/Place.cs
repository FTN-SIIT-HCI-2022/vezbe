using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public abstract class Place : INotifyPropertyChanged
    {
        public Place()
        {
        }
        public Place(string name, string description, Address address, List<BusinessHours> businessHours)
        {
            Name = name;
            Description = description;
            Address = address;
            BusinessHours = businessHours;
        }

        //radnja koja moze da bude prodavnica ili restoran, klijenti iz njih mogu da narucuju
        private string _name; 
        private string _description;
        public string Name { 
            get
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

        public string Description { get { return _description; }
            set {
                if(_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public Address Address { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        //TO DO: lista radnog vremena 
        // dan, pocetak, kraj
        public List<BusinessHours> BusinessHours { get; set; }
    }

}
