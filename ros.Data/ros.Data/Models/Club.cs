using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ros.Data.Models
{
    public class Club
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Club()
        {
            ContactAddresses = new HashSet<ContactAddress>();
            Entries = new HashSet<Entry>();
            Regattas = new HashSet<Regatta>();
            Users = new HashSet<User>();
        }

        public int ClubId { get; set; }

        public int ContactPersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string ClubName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime RegistrationDateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string LogoUrl { get; set; }

        [StringLength(255)]
        public string WebSiteUrl { get; set; }

        public virtual ContactPerson ContactPerson { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddress> ContactAddresses { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entries { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Regatta> Regattas { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}