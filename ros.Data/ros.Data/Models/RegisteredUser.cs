using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ros.Data.Models
{
    public class RegisteredUser
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegisteredUser()
        {
            RegisteredUserSocialEvents = new HashSet<RegisteredUserSocialEvent>();
            Teams = new HashSet<Team>();
            Teams1 = new HashSet<Team>();
        }

        public int RegisteredUserId { get; set; }

        public int UserId { get; set; }

        public int EntryId { get; set; }

        public double AmountPaid { get; set; }

        public virtual Entry Entry { get; set; }

        public virtual User User { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredUserSocialEvent> RegisteredUserSocialEvents { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams1 { get; set; }
    }
}