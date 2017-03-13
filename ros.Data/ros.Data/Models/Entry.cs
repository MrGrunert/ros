using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ros.Data.Models.JunctionTables;

namespace ros.Data.Models
{
    public class Entry
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entry()
        {
            RegattaEntries = new HashSet<RegattaEntry>();
            RegisteredUsers = new HashSet<RegisteredUser>();
            Teams = new HashSet<Team>();
        }

        public int EntryId { get; set; }

        public int EntryNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EntryName { get; set; }

        public DateTime RegistrationDate { get; set; }

        public double AmountPaid { get; set; }

        public int UserId { get; set; }

        public int ClubId { get; set; }

        public int? BoatId { get; set; }

        public virtual Boat Boat { get; set; }

        public virtual Club Club { get; set; }

        public virtual User User { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegattaEntry> RegattaEntries { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredUser> RegisteredUsers { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams { get; set; }
    }
}