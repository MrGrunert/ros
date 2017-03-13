using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ros.Data.Models.JunctionTables;

namespace ros.Data.Models
{
    public class RaceEvent
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RaceEvent()
        {
            RaceEventTeams = new HashSet<RaceEventTeam>();
            Results = new HashSet<Result>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RaceEventId { get; set; }

        public double MaxRaceHcp { get; set; }

        public double MinRaceHcp { get; set; }

        public virtual Event Event { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RaceEventTeam> RaceEventTeams { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}