using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class Offer
    {
       // ponuda odnosi se na listu itema i cenu 
       public List<Item> Items { get; set; }
        public string Name { get; set; }    
        public double Price { get; set; }
    }
}
