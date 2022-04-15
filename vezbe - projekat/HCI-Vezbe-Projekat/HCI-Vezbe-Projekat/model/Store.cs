using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Store : Place
    {

        public StoreType StoreType { get; set; }

        public List<Offer> Offers { get; set; }

        public Store() { }
        public Store(string name, string description, Address address, List<BusinessHours> businessHours, StoreType type, List<Offer> offers)
            : base(name, description, address, businessHours)
        {
            StoreType = type;
            Offers = offers;
        }
        public Store(StoreType type, List<Offer> offers)
        {
            StoreType=type;
            Offers = offers;
        }



    }
    public enum StoreType
    {
        MARKET, PHARMACY, BOUTIQUE
    }
}
