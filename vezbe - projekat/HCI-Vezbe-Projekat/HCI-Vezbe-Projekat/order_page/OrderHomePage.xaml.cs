using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.order_page;
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
    /// Interaction logic for OrderHomePage.xaml
    /// </summary>
    public partial class OrderHomePage : Page
    {
        MockData data;
        Frame frame_page;
        public OrderHomePage(MockData mockData, Frame page)
        {
            InitializeComponent();
            data = mockData;
            frame_page = page;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            frame_page.Content = new AddNewOrderPage(data, frame_page);
        }
    }
}
