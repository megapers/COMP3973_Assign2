using System;

namespace Assign2.Models
{
    public class UpdateUserModel
    {
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }  
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public bool IsNaughty { get; set; }
    }
}        
