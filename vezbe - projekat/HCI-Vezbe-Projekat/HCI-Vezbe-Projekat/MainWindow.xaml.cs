using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.user_page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI_Vezbe_Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MockData data = new MockData(); 
        public MainWindow()
        {
            InitializeComponent();
            
            if (data.LoginUser != null)
            {
                // neko je ulogovan 
                if(data.LoginUser.Role == model.Role.CLIENT || data.LoginUser.Role == model.Role.DELIVERER)
                {
                    user_btn.Content = "Profile";
                }
            }
            else
            {
                //niko nije ulogovan prikazi mu stranicu za logovanje
                page.Content = new MainPage(data, page);
            }
        }

        private void user_btn_Click(object sender, RoutedEventArgs e)
        {
            //klikom na ovo dugme otvara se stranica za korisnike 
            //posto imamo vise korisnika onda moze da se otvori i profile stranica u zavisnosti od toga ko je ulogovan
            if (data.LoginUser != null)
            {
                // neko je ulogovan 
                if (data.LoginUser.Role == model.Role.CLIENT || data.LoginUser.Role == model.Role.DELIVERER)
                {
                    page.Content = new UserProfilePage();
                }else
                {
                    page.Content = new UserPage();
                }
            }
            
        }

        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            //klikom na ovo dugme vracamo se na home stranice
            if (data.LoginUser != null)
            {
                //onda cemo otvoriti neku drugu stranicu, na casu cemo se dogovoriti koju
            }else
            {
                //ako niko nije ulogovan onda se otvara stranica za logovanje
                page.Content = new MainPage(data, page);
            }
            
        }

        private void res_btn_Click(object sender, RoutedEventArgs e)
        {
            page.Content = new RestaurantHome(data, page);
        }

        private void market_btn_Click(object sender, RoutedEventArgs e)
        {
          //  Button button = e.Source as Button;
          //  button.Background = new SolidColorBrush(Color.FromRgb(10, 10,10));
            // Button button1 = new Button(); 
            // grid.Children.Add(button1);
            page.Content = new MarketHomePage(data, page );
          
        }

        private void spec_offer_Click(object sender, RoutedEventArgs e)
        {
            
            // Button button = (Button)sender;
          /*  Button button = e.Source as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(200, 150, 200));

            Button btn = new Button();
            grid.Children.Add(btn);*/
            page.Content = new SpecOfferHomePage(data, page);
        }

        private void order_btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(Color.FromRgb(250, 200, 230));
            /*
            Button btn2 = new Button();
            btn2.Content = "iz koda";
            grid.Children.Add(btn2);*/
            page.Content = new OrderHomePage(data, page);
        }
    }
}
