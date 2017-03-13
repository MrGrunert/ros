using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ros.Data.Models
{
    public class ContactAddress
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactAddress()
        {
            Events = new HashSet<Event>();
            Regattas = new HashSet<Regatta>();
        }

        public int ContactAddressId { get; set; }

        public int ContactAddressNumber { get; set; }

        public int ClubId { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string ContactAddressType { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        public int ZipCode { get; set; }

        public virtual Club Club { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Regatta> Regattas { get; set; }
    }
}