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

namespace HCI_Vezbe_Projekat.offer_page
{
    /// <summary>
    /// Interaction logic for AddSpecialOfferPage.xaml
    /// </summary>
    public partial class AddSpecialOfferPage : Page
    {
        MockData data;
        Frame page_frame;
        Offer newSpecialOffer; 
        public AddSpecialOfferPage(MockData mock_data, Frame page)
        {
            InitializeComponent();
            data = mock_data;
            page_frame = page;
            newSpecialOffer = new Offer();
            this.DataContext = newSpecialOffer;

        }
    }
}
