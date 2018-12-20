using System;
using System.ComponentModel.DataAnnotations;

namespace LiarisHR.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public object BusinessName { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage= "You must specifiy a password between 4 & 8 characters.")]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object Skills { get; set; }
        public int PayRate { get; set; }
    }
}