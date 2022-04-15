using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    //predstavlja jelo ili artikl u prodavnici
    public class Item
    {

        public Item(string n, string d)
        {
            Name = n;
            Description = d;
        }
        public string Name { get; set; }    
        public string Description { get; set; }
       
    }
}
