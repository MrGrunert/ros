using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ros.Data.Models.JunctionTables
{
    public class RaceEventTeam
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RaceEventId { get; set; }

        [Required]
        [StringLength(50)]
        public string StartLocation { get; set; }

        [Required]
        [StringLength(50)]
        public string EndLocation { get; set; }

        public virtual RaceEvent RaceEvent { get; set; }

        public virtual Team Team { get; set; }
    }
}