using System;
using System.ComponentModel.DataAnnotations;

namespace ros.Data.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public int RegattaId { get; set; }

        public int ContactAddressId { get; set; }

        [Required]
        [StringLength(50)]
        public string EventName { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int EventFee { get; set; }

        public int? MaxAmountOfParticipants { get; set; }

        public virtual ContactAddress ContactAddress { get; set; }

        public virtual Regatta Regatta { get; set; }

        public virtual RaceEvent RaceEvent { get; set; }

        public virtual SocialEvent SocialEvent { get; set; }
    }
}