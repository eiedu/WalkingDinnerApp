using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace WalkingDinnerWeb.Models
{
    public class DinnerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DinnerName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? PrepTime { get; set; }
        public int NumOfRounds { get; set; }
        public int Parallel { get; set; }

        public virtual ICollection<DuoModel> Participants { get; set; }
        public virtual ICollection<RoundModel> Rounds { get; set; }

        public DinnerModel()
        {
            Participants = new List<DuoModel>();
            Rounds = new List<RoundModel>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{Id}");
            sb.Append($"{DinnerName}");
            sb.Append($"{StartTime.ToString()}");
            sb.Append($"{PrepTime.ToString()}");
            sb.Append($"{NumOfRounds}");
            sb.Append($"{Parallel}");
            sb.Append($"{Participants.Count}");
            sb.Append($"{Rounds.Count}");
            return sb.ToString();
        }
    }
}