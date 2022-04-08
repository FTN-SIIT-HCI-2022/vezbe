using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.restaurant_page;
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
    /// Interaction logic for RestaurantHome.xaml
    /// </summary>
    public partial class RestaurantHome : Page
    {
        MockData data;
        Frame page_frame;

        public RestaurantHome(MockData mockData, Frame frame)
        {
            InitializeComponent();
            data = mockData;
            page_frame = frame;
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            //otvaramo stranicu za dodavanje novog restorana 
            page_frame.Content = new AddNewRestaurant(data, page_frame);
        }
    }
}
