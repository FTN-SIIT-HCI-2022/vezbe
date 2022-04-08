using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.model;
using HCI_Vezbe_Projekat.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page, INotifyPropertyChanged
    {
        private string _username; 
        private string _password;   

        public string Username
        {
            get { return _username; }
            set
            {
                if(value != _username)
                {
                    _username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if( value != _password)
                {
                  _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        private MockData data;
        public MainPage(MockData mockData, Frame page)
        {
            InitializeComponent();
            this.DataContext = this;
            data = mockData;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private void sign_in_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uneli ste podatke: " + Username + " " + Password);
           
        }
    }
}
