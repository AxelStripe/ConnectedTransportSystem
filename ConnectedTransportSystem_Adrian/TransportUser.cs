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

        public TransportUser(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
