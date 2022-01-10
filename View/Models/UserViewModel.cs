﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace View.Models
{
    class UserViewModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public UserViewModel(string _name, string _email, string _password)
        {
            //test 2
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
            this.RegisterDate = DateTime.Now;
        }

        public void addAdress(string _country, string _state, string _city, string _street, int _housenumber, string _postalCode)
        {
            this.Country = _country;
            this.State = _state;
            this.City = _city;
            this.Street = _street;
            this.HouseNumber = _housenumber;
            this.PostalCode = _postalCode;
        }
    }
}