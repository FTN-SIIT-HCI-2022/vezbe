using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.store_page;
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
    /// Interaction logic for MarketHomePage.xaml
    /// </summary>
    public partial class MarketHomePage : Page
    {
        MockData data;
        Frame page_frame;
        public MarketHomePage(MockData mockData, Frame frame)
        {
            InitializeComponent();
            data = mockData;
            page_frame = frame;
        }

        private void add_store_Click(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddNewMarketPage(data, page_frame);
        }
    }
}
