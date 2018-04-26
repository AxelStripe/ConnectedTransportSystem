using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedTransportSystem_Adrian
{
    public class TransportData
    {
        private List<TransportUser> _users;
        private TransportUser _loggedInUser;

        public TransportData()
        {
            _users = new List<TransportUser>();
        }

        public bool AddUser(TransportUser user)
        {
            //only add a user if there is noone else with the same username
            foreach (TransportUser u in _users)
            {
                if (u.GetUsername() == user.GetUsername())
                    return false;
            }

            _users.Add(user);
            return true;
        }

        public bool AuthoriseUser(string username, string password)
        {
            foreach(TransportUser u in _users)
            {
                //search for the user
                if(username == u.GetUsername())
                {
                    //found user, check password
                    if (password == u.GetPassword())
                    {
                        //log user in
                        SetLoggedInUser(u);
                        return true;
                    }   
                    else
                        return false;
                }
            }

            return false;
        }

        public TransportUser GetLoggedInUser()
        {
            return _loggedInUser;
        }

        public void SetLoggedInUser(TransportUser user)
        {
            _loggedInUser = user;
        }
    }
}
