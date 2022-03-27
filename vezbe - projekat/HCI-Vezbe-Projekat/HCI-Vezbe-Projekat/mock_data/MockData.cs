using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCI_Vezbe_Projekat.model;

namespace HCI_Vezbe_Projekat.mock_data
{

    //ova klasa ce nam biti nesto kao baza podataka, imace sve neophodne podatke za rad aplikacije 

    public class MockData
    {

        public MockData()
        {
            //kada se kreira objekat klase popune se sve liste i mapa 
            LoginUser = null; //na pocetku dok se niko ne uloguje 
            fillUserDictionary();
        }

        public User LoginUser { get; set; } // predstavlja korisnika koji je trenutno ulogovan, ako je null onda niko nije ulogovan 

        //recnik korisnika koji trenutno postoje u sistemu, kljuc - username, a value - objekat klase user
        public Dictionary<string, User> UserList { get; set; }


        //lista narudzbina 


        //lista restorana 

        //lista specijalnih ponuda

        //lista prodavnica


        private void fillUserDictionary()
        {
            UserList = new Dictionary<string, User>();

            UserList.Add("petrap", new User("petrap", "12345", "Petra", "Peric",
                new Address("Vuka Karadzica 5", "Novi Sad", "21000", "Srbija"), Role.MANAGER));
            UserList.Add("lenka", new User("lenka", "12345", "Lenka", "Mikic",
                new Address("Nikole Tesle 10", "Beograd", "11000", "Srbija"), Role.MANAGER));

            //deliverers
            UserList.Add("peraperic", new Deliverer("peraperic", "12345", "Pera", "Peric",
                new Address("Narodnog fronta 1", "Novi Sad", "21000", "Srbija"), Role.DELIVERER, true));
            UserList.Add("mikamikic", new Deliverer("mikamikic", "12345", "Mika", "Mikic",
                new Address("Bulevar Kralja Petra", "Beograd", "11000", "Srbija"), Role.DELIVERER, true));

            //clients
            UserList.Add("masam", new Client("masam", "12345", "Masa", "Markovic",
                new Address("Maksima Gorkog", "Novi Sad", "21000", "Srbija"), Role.CLIENT));
            UserList.Add("milan", new Client("milan", "12345", "Milan", "Milankovic",
                new Address("Milutina Milankovica", "Beograd", "11000", "Srbija"), Role.CLIENT));


        }
    }
}
