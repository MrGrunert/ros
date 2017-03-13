using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ros.Data.Models
{
    public class SocialEvent
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SocialEvent()
        {
            RegisteredUserSocialEvents = new HashSet<RegisteredUserSocialEvent>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SocialEventId { get; set; }

        [Required]
        [StringLength(50)]
        public string SocialEventType { get; set; }

        public virtual Event Event { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredUserSocialEvent> RegisteredUserSocialEvents { get; set; }
    }
}