using HCI_Vezbe_Projekat.mock_data;
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

namespace HCI_Vezbe_Projekat.user_page
{
    /// <summary>
    /// Interaction logic for UserProfilePage.xaml
    /// </summary>
    public partial class UserProfilePage : Page
    {
        MockData data;
        Frame page;
        public UserProfilePage(MockData mockData, Frame frame)
        {
            InitializeComponent();
            data = mockData;    
            page = frame;

            // dodamo dugme koje ce otvoriti stranicu za prikaz svih korisnika
            // otvara se samo ako je ulogovan menadzer 
            if (data.LoginUser.Role == model.Role.MANAGER)
            {
                Button btn = new Button();
                btn.Content = "Show All Users";
                btn.Click += Btn_Click;
                btn_show.Children.Add(btn);


            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            page.Content = new UserPage(data, page);
        }
    }
}
