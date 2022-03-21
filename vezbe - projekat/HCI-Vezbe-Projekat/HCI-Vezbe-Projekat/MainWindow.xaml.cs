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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            page.Content = new MainPage();
        }

        private void user_btn_Click(object sender, RoutedEventArgs e)
        {
            //klikom na ovo dugme otvara se stranica za korisnike 
            page.Content = new UserPage();
        }

        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            //klikom na ovo dugme vracamo se na home stranice
            page.Content = new MainPage();
            
        }
    }
}
