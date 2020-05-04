using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WalkingDinnerWeb.Models
{
    public class DuoModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public string FirstNameOne { get; set; }
        [Required]
        public string LastNameOne { get; set; }
        [Required]
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
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string Dietary { get; set; }
    }
}