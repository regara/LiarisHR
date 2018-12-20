using System;

namespace LiarisHR.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string ProfileImageURL { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object Skills { get; set; }
        public int PayRate { get; set; }
        public object BusinessName { get; set; }
    }
}