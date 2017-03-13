using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ros.Data.Models
{
    public class Boat
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boat()
        {
            Entries = new HashSet<Entry>();
            Results = new HashSet<Result>();
        }

        public int BoatId { get; set; }

        public int SailNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string BoatName { get; set; }

        public double Hcp { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string BoatType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entries { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}