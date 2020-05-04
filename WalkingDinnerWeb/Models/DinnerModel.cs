using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WalkingDinnerWeb.Models
{
    public class DinnerModel
    {
        public int Id { get; set; }
        [Required]
        public string DinnerName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime PrepTime { get; set; }
        public int NumOfRounds { get; set; }
        public int Parallel { get; set; }

        public ICollection<DuoModel> Participants { get; set; }
        public ICollection<RoundModel> Rounds { get; set; }
    }
}