using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.offer_page;
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
    /// Interaction logic for SpecOfferHomePage.xaml
    /// </summary>
    public partial class SpecOfferHomePage : Page
    {
        MockData data;
        Frame page_frame;
        public SpecOfferHomePage(MockData mockData, Frame page )
        {
            InitializeComponent();
            data = mockData;
            page_frame = page;
            this.DataContext = data;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddSpecialOfferPage(data, page_frame);
            
        }
    }
}
