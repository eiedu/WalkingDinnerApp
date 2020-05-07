using System.ComponentModel.DataAnnotations;

namespace WalkingDinnerWeb.Models
{
    public class DuoModel
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string FirstNameOne { get; set; }

        [Required]
        public string LastNameOne { get; set; }

        public string InsertionOne { get; set; }

        public string FirstNameTwo { get; set; }
        public string LastNameTwo { get; set; }
        public string InsertionTwo { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string City { get; set; }

        //Saved phonenumber in a string
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        //Iban So there is somewhere to pay 
        [Required]
        public string IBan { get; set; }

        public string Dietary { get; set; }
    }
}