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

namespace HCI_Vezbe_Projekat
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        MockData data;
        Frame page;
        public UserPage(MockData mock, Frame frame)
        {
            InitializeComponent();
            data = mock;    
            page = frame;
            DataContext = data;
        }

        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if(e.Column.Header.ToString() == "Password")
            {
                e.Column.Visibility = Visibility.Hidden;
            }else if(e.Column.Header.ToString() == "UserName")
            {
                e.Column.Header = "User name";
            }
        }
    }
}
