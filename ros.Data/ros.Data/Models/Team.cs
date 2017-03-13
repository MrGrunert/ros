using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ros.Data.Models.JunctionTables;

namespace ros.Data.Models
{
    public class Team
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            RaceEventTeams = new HashSet<RaceEventTeam>();
            Results = new HashSet<Result>();
            RegisteredUsers = new HashSet<RegisteredUser>();
        }

        public int TeamId { get; set; }

        public int TeamNumber { get; set; }

        public int EntryId { get; set; }

        public int SkipperId { get; set; }

        public virtual Entry Entry { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RaceEventTeam> RaceEventTeams { get; set; }

        public virtual RegisteredUser RegisteredUser { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredUser> RegisteredUsers { get; set; }
    }
}