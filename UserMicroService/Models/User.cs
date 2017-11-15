using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMicroService.Models;

namespace UserMicroService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return "Id: " + Id.ToString() + "Name: " + Name;
        }
    }
}
