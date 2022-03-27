using HCI_Vezbe_Projekat.mock_data;
using HCI_Vezbe_Projekat.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.services
{
    public class UserService
    {

        //sve funkcije za rad sa korisnicima 

        public bool login(string username, string password, MockData mockData )
        {
            
            if(username == null || password == null) { return false; }
            if (mockData.UserList.ContainsKey(username))
            {
                if (mockData.UserList[username].Password.Equals(password))
                {

                    mockData.LoginUser = mockData.UserList[username];
                    return true;
                }
                else
                    return false;
            }

            return false;
        }
    }
}
