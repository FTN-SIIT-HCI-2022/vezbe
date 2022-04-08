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

namespace HCI_Vezbe_Projekat.store_page
{
    /// <summary>
    /// Interaction logic for AddNewMarketPage.xaml
    /// </summary>
    public partial class AddNewMarketPage : Page
    {
        MockData data;
        Frame page_frame;
        Store newMarket; 
        public AddNewMarketPage(MockData mockData, Frame page)
        {
            InitializeComponent();
            data = mockData;
            page_frame = page;
            newMarket  = new Store();
            this.DataContext = newMarket;
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uneseno ime: " + newMarket.Name);
        }
    }
}
