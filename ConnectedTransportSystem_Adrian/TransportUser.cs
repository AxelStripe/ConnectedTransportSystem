using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedTransportSystem_Adrian
{
    public class TransportUser
    {
        private string _username;
        private string _password;
        private string _email;

        public TransportUser(string username, string password, string email)
        {
            _username = username;
            _password = password;
            _email = email;
        }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }

        public string GetEmail()
        {
            return _email;
        }
    }
}
