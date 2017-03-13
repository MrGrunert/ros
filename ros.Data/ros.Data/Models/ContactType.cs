using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ros.Data.Models
{
    public class ContactType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactType()
        {
            ContactPersons = new HashSet<ContactPerson>();
        }

        public int ContactTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPerson> ContactPersons { get; set; }
    }
}