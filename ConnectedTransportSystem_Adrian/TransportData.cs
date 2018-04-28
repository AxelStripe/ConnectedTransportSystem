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

        //journey details
        private string _startPoint;
        private string _startTime;
        private string _endPoint;
        private string _endTime;

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
                        _loggedInUser = u;
                        return true;
                    }   
                    else
                        return false;
                }
            }

            return false;
        }

        public bool ValidateEmail(string email)
        {
            return email == _loggedInUser.GetEmail();
        }

        public TransportUser GetLoggedInUser()
        {
            return _loggedInUser;
        }

        public void LogOutUser()
        {
            _loggedInUser = null;
        }

        public void SetJourney(string startPoint, string startTime, string endPoint, string endTime)
        {
            _startPoint = startPoint;
            _startTime = startTime;
            _endPoint = endPoint;
            _endTime = endTime;
        }

        public string GetJourney()
        {
            return "Departing From: " + _startPoint + ", at: " + _startTime + ". Arriving at: " + _endPoint + ", at: " + _endTime;
        }
    }
}
