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
            fillRestaurantList();
            fillStoreList();
            fillOfferList();
            fillOrderList();
        }

        public List<Order> Orders { get; set; }
        private void fillOrderList()
        {
            Item i = new Item("kljucko", "ime za salamu");
            Item i1 = new Item("milka cokoladica", "cokoladica od bele cokolade");
            Item i3 = new Item("mleko", "sveze mleko, pasterizovano");
            List<Item> items = new List<Item>();
            items.Add(i);
            items.Add(i1);
            items.Add(i3);
        }

        private void fillOfferList()
        {
            Item i = new Item("kljucko", "ime za salamu");
            Item i1 = new Item("milka cokoladica", "cokoladica od bele cokolade");
            Item i3 = new Item("mleko", "sveze mleko, pasterizovano");

            List<Item> items = new List<Item>();
            items.Add(i);
            items.Add(i1);
            items.Add(i3);

            List<Item> items2 = new List<Item>();
            items2.Add(i3);
            Offers = new List<Offer>();

            Offers.Add(new Offer(items, "dorucak", 230, "dorucak 1"));
            Offers.Add(new Offer(items2, "cokolada", 100, "milka cokolada od 100gr"));
            Offers.Add(new Offer(items, "dorucak", 230, "dorucak 1"));

            Client u1 =new Client("masam", "12345", "Masa", "Markovic",
               new Address("Maksima Gorkog", "Novi Sad", "21000", "Srbija"), Role.CLIENT);
            Client u2 =  new Client("milan", "12345", "Milan", "Milankovic",
                new Address("Milutina Milankovica", "Beograd", "11000", "Srbija"), Role.CLIENT);

            Place p = new Restaurant("Karibik", "Restoran brze hrane!", new Address("Bulevar Oslobodjenja 83", "Novi Sad", "21000", "Srbija"), new List<BusinessHours>(), RestaurantType.FAST_FOOD, new List<Offer>());
            Orders = new List<Order>
            {
          
                new Order("ord 1",u1, new Address("Maksima Gorkog", "Novi Sad", "21000", "Srbija"), p, items, 200, new DateTime(), OrderState.WAIT )

            };
        }

        private void fillStoreList()
        {
            Stores = new List<Store>();
            List<BusinessHours> hours = new List<BusinessHours>();
            hours.Add(new BusinessHours(DayOfWeek.Monday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Tuesday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Wednesday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Thursday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Friday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Sunday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Saturday, new TimeOnly(11, 0), new TimeOnly(20, 0)));
            Stores.Add(new Store("Maxi", "Lanac prodavnica", new Address("Bulevar Oslobodjenja 83", "Novi Sad", "21000", "Srbija"), hours, StoreType.MARKET, new List<Offer>()));
            Stores.Add(new Store("Benu", "Apoteka", new Address("Sutjeska 2", "Novi Sad", "21000", "Srbija"), hours, StoreType.PHARMACY, new List<Offer>()));
            Stores.Add(new Store("Legend", "Butik odece", new Address("Bulevar Oslobodjenja 119", "Novi Sad", "21000", "Srbija"), hours, StoreType.BOUTIQUE, new List<Offer>()));
            Stores.Add(new Store("DM", "Drogerija, mark", new Address("Zmaj Jovina 28", "Novi Sad", "21000", "Srbija"), hours, StoreType.MARKET, new List<Offer>()));

        }

        private void fillRestaurantList()
        {
            // popunimo listu restorana 
            Restaurants = new List<Restaurant>();
            List<BusinessHours> hours = new List<BusinessHours>();
            hours.Add(new BusinessHours(DayOfWeek.Monday, new TimeOnly(10, 0), new TimeOnly(22,0)));
            hours.Add(new BusinessHours(DayOfWeek.Tuesday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Wednesday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Thursday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Friday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Sunday, new TimeOnly(10, 0), new TimeOnly(22, 0)));
            hours.Add(new BusinessHours(DayOfWeek.Saturday, new TimeOnly(11, 0), new TimeOnly(20, 0)));
            Restaurants.Add(new Restaurant("Karibik", "Restoran brze hrane!", new Address("Bulevar Oslobodjenja 83", "Novi Sad", "21000", "Srbija" ), hours, RestaurantType.FAST_FOOD,new List<Offer>()));
            Restaurants.Add(new Restaurant("Plava frajla", "Restoran domace kuhinje!", new Address("Sutjeska 2", "Novi Sad", "21000", "Srbija"), hours, RestaurantType.RESTAURANT, new List<Offer>()));
            Restaurants.Add(new Restaurant("Pizza lab", "Laboratorija pice i kafe", new Address("Temerinska 24", "Novi Sad", "21000", "Srbija"), hours, RestaurantType.PIZZERIA, new List<Offer>()));
            Restaurants.Add(new Restaurant("Irish pub", "Prvi i najstariji urski pub u Novom Sadu.", new Address("Zmaj Jovina 28", "Novi Sad", "21000", "Srbija"), hours, RestaurantType.PUB, new List<Offer>()));
            Restaurants.Add(new Restaurant("Brunch Sweets", "Sladoled, torte, kolaci...", new Address("Bulevar Oslobodjenja 119", "Novi Sad", "21000", "Srbija"), hours, RestaurantType.PASTRY_SHOP, new List<Offer>()));
        }

        public User LoginUser { get; set; } // predstavlja korisnika koji je trenutno ulogovan, ako je null onda niko nije ulogovan 

        //recnik korisnika koji trenutno postoje u sistemu, kljuc - username, a value - objekat klase user
        public Dictionary<string, User> UserList { get; set; }


        //lista narudzbina 


        //lista restorana 
        public List<Restaurant> Restaurants { get; set; }

        //lista specijalnih ponuda
        public List<Offer> Offers { get; set; } 

        //lista prodavnica
        public List<Store> Stores { get; set; }

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
