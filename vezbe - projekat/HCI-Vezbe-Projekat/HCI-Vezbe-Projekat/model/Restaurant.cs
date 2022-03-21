using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Restaurant : Place
    {
        public RestaurantType RestaurantType { get; set; }

        public List<Offer> Offers { get; set; }

        // razmisliti da li jos nesto moze da se doda
    }



    public enum RestaurantType
    {
        PUB, PIZZERIA, PASTRY_SHOP, FAST_FOOD
    }
}
