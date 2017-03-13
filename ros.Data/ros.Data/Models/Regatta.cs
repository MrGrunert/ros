using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ros.Data.Models.JunctionTables;

namespace ros.Data.Models
{
    public class Regatta
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Regatta()
        {
            Events = new HashSet<Event>();
            RegattaEntries = new HashSet<RegattaEntry>();
        }

        public int RegattaId { get; set; }

        public int ClubId { get; set; }

        public int ContactAddressId { get; set; }

        public int ContactPersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string RegattaName { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int RegattaFee { get; set; }

        [Required]
        [StringLength(50)]
        public string RegattaDescription { get; set; }

        public int? MaxAmountOfEntries { get; set; }

        public virtual Club Club { get; set; }

        public virtual ContactAddress ContactAddress { get; set; }

        public virtual ContactPerson ContactPerson { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegattaEntry> RegattaEntries { get; set; }
    }
}