using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.model;
using HCI_Vezbe_Projekat.services;
using HCI_Vezbe_Projekat.user_page;
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
        private UserService userService;
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
        Frame frame_page;
        public MainPage(MockData mockData, Frame page)
        {
            InitializeComponent();
            this.DataContext = this;
            data = mockData;
            userService = new UserService();
            frame_page = page;
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
            //pozvacemo funkciju iz servisa 
            MessageBox.Show("Uneli ste podatke: " + Username + " " + Password);
            bool isLogin = userService.login(Username, Password, data);


            if (isLogin == false)
            {
                MessageBox.Show("Incorrect username or password.");
            }
            else
            {

                MessageBox.Show("Successful login - " + data.LoginUser.Name + " " + data.LoginUser.Surname);
                frame_page.Content = new UserProfilePage(data, frame_page);

            }



        }
    }
}
