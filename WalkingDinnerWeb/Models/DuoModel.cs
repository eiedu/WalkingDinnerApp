using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WalkingDinnerWeb.Models
{
    public class DuoModel
    {
        [Key]
        public int Id { get; set; }

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
        [Required,Phone]
        public string PhoneNumber { get; set; }

        [Required,EmailAddress]
        public string Email { get; set; }
        //Iban So there is somewhere to pay 
        [Required]
        public string IBan { get; set; }

        public string Dietary { get; set; }

        public virtual ICollection<RoundModel> Rounds { get; set; }
        public virtual ICollection<DinnerModel> Dinners { get; set; }

        public DuoModel()
        {
            Rounds = new List<RoundModel>();
            Dinners = new List<DinnerModel>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{Id}");
            sb.Append($"{UserId} ");
            sb.Append($"{FirstNameOne} ");
            sb.Append($"{InsertionOne} ");
            sb.Append($"{LastNameOne} ");
            sb.Append($"{FirstNameTwo} ");
            sb.Append($"{InsertionTwo} ");
            sb.Append($"{LastNameTwo} ");
            sb.Append($"{StreetName} ");
            sb.Append($"{HouseNumber} ");
            sb.Append($"{PostalCode} ");
            sb.Append($"{City} ");
            sb.Append($"{PhoneNumber} ");
            sb.Append($"{Email} ");
            sb.Append($"{IBan} ");
            sb.Append($"{Dietary} ");
            return sb.ToString();
        }
    }
}