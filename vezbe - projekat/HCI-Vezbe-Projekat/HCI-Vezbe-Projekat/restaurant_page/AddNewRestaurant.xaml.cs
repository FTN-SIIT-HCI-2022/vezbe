using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.model;
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

namespace HCI_Vezbe_Projekat.restaurant_page
{
    /// <summary>
    /// Interaction logic for AddNewRestaurant.xaml
    /// </summary>
    public partial class AddNewRestaurant : Page
    {
        MockData data;
        Frame page_frame;
        Restaurant newRestaurant; 
        public AddNewRestaurant(MockData mockData, Frame frame)
        {
            InitializeComponent();
            newRestaurant = new Restaurant();
            this.DataContext = newRestaurant;
            data = mockData;
            page_frame = frame;
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ime restorana " + newRestaurant.Name);
        }
    }
}
