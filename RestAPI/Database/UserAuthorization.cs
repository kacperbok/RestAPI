
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    class UserAuthorization
    {

        private static string UserName { get; set; }
        private static string Password { get; set; }


        public UserAuthorization(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool Authorization()
        {          
            DataBaseConnection UserAuthorizationConnection = new DataBaseConnection();
            
   

            return true;
        }


    }
}
