using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class User
    {
        #region vars
        string name;
        string email;
        string password;
        DateTime registerDate;
        string userID;
        string country;
        string state;
        string city;
        string street;
        int housenumber;
        string postalCode;
        #endregion

        public User(string _name, string _email, string _password)
        {
            //test 2
            this.name = _name;
            this.email = _email;
            this.password = _password;
            this.registerDate = DateTime.Now;
            this.userID = generateUserID();
        }

        private string generateUserID()
        {
            return "";
        }

        public void addAdress(string _country, string _state, string _city, string _street, int _housenumber, string _postalCode)
        {
            this.country = _country;
            this.state = _state;
            this.city = _city;
            this.street = _street;
            this.housenumber = _housenumber;
            this.postalCode = _postalCode;
        }
    }
}
