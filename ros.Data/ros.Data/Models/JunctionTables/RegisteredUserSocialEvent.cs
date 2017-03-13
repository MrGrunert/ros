using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ros.Data.Models.JunctionTables
{
    public class RegisteredUserSocialEvent
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SocialEventId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegisteredUserId { get; set; }

        public int? AmountOfFriends { get; set; }

        public virtual RegisteredUser RegisteredUser { get; set; }

        public virtual SocialEvent SocialEvent { get; set; }
    }
}