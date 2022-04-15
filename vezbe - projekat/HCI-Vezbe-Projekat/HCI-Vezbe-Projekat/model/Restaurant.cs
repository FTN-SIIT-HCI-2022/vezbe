using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Restaurant : Place
    {
        public Restaurant() { }
        public Restaurant(string name, string description, Address address, List<BusinessHours> businessHours, RestaurantType type, List<Offer> offers) 
            : base(name, description, address, businessHours)
        {
            RestaurantType = type;
            Offers = offers;
        }
        public Restaurant(RestaurantType restaurantType, List<Offer> offers)
        {
            RestaurantType = restaurantType;
            Offers = offers;
        }

        public RestaurantType RestaurantType { get; set; }

        public List<Offer> Offers { get; set; }

        // razmisliti da li jos nesto moze da se doda
         
    }



    public enum RestaurantType
    {
        PUB, PIZZERIA, PASTRY_SHOP, FAST_FOOD, RESTAURANT
    }
}
