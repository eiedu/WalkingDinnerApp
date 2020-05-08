using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WalkingDinnerWeb.Models
{
    public class RoundModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DinnerModel DinnerId { get; set; }
        [Required]
        public DuoModel HostId { get; set; }
        [Required]
        public string RoundName { get; set; }
        [Required]
        public int RoundNumber { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        public ICollection<string> Dietary { get; set; }
        [Required]
        public ICollection<DuoModel> Participants { get; set; }
    }
}