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

namespace HCI_Vezbe_Projekat.order_page
{
    /// <summary>
    /// Interaction logic for AddNewOrderPage.xaml
    /// </summary>
    public partial class AddNewOrderPage : Page
    {
        MockData data;
        Frame page_frame;
        Order newOrder;
        public AddNewOrderPage(MockData mockData, Frame page)
        {
            InitializeComponent();
            data = mockData;
            page_frame = page;
            newOrder = new Order();
            this.DataContext = newOrder;

        }
    }
}
