using System.ComponentModel.DataAnnotations;

namespace ros.Data.Models
{
    public class Result
    {
        public int ResultId { get; set; }

        public int RaceEventId { get; set; }

        public int TeamId { get; set; }

        public int BoatId { get; set; }

        [Required]
        [StringLength(50)]
        public string ResultTime { get; set; }

        [Required]
        [StringLength(50)]
        public string CalculatedResultTime { get; set; }

        public double ResultDistance { get; set; }

        public double CalculatedResultDistance { get; set; }

        public int Rank { get; set; }

        public int? Penalty { get; set; }

        public bool? IsDisqualified { get; set; }

        public virtual Boat Boat { get; set; }

        public virtual RaceEvent RaceEvent { get; set; }

        public virtual Team Team { get; set; }
    }
}