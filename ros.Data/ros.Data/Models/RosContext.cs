using System.Data.Entity;
using ros.Data.Models.JunctionTables;

namespace ros.Data.Models
{
    public class RosContext : DbContext
    {
        public RosContext()
            : base("name=RosContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Boat> Boats { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<ContactAddress> ContactAddresses { get; set; }
        public virtual DbSet<ContactPerson> ContactPersons { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<RaceEvent> RaceEvents { get; set; }
        public virtual DbSet<RaceEventTeam> RaceEventTeams { get; set; }
        public virtual DbSet<RegattaEntry> RegattaEntries { get; set; }
        public virtual DbSet<Regatta> Regattas { get; set; }
        public virtual DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public virtual DbSet<RegisteredUserSocialEvent> RegisteredUserSocialEvents { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<SocialEvent> SocialEvents { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boat>()
                .Property(e => e.BoatName)
                .IsUnicode(false);

            modelBuilder.Entity<Boat>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Boat>()
                .Property(e => e.BoatType)
                .IsUnicode(false);

            modelBuilder.Entity<Boat>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Boat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.ClubName)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.LogoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.WebSiteUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.ContactAddresses)
                .WithRequired(e => e.Club)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Entries)
                .WithRequired(e => e.Club)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Regattas)
                .WithRequired(e => e.Club)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Clubs)
                .Map(m => m.ToTable("ClubUsers").MapLeftKey("ClubId").MapRightKey("UserId"));

            modelBuilder.Entity<ContactAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ContactAddress>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<ContactAddress>()
                .Property(e => e.ContactAddressType)
                .IsUnicode(false);

            modelBuilder.Entity<ContactAddress>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<ContactAddress>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.ContactAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactAddress>()
                .HasMany(e => e.Regattas)
                .WithRequired(e => e.ContactAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactPerson>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPerson>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPerson>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPerson>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Clubs)
                .WithRequired(e => e.ContactPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Regattas)
                .WithRequired(e => e.ContactPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.ContactPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.ContactPersons)
                .WithRequired(e => e.ContactType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.EntryName)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .HasMany(e => e.RegattaEntries)
                .WithRequired(e => e.Entry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entry>()
                .HasMany(e => e.RegisteredUsers)
                .WithRequired(e => e.Entry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entry>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Entry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasOptional(e => e.RaceEvent)
                .WithRequired(e => e.Event);

            modelBuilder.Entity<Event>()
                .HasOptional(e => e.SocialEvent)
                .WithRequired(e => e.Event);

            modelBuilder.Entity<RaceEvent>()
                .HasMany(e => e.RaceEventTeams)
                .WithRequired(e => e.RaceEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RaceEvent>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.RaceEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RaceEventTeam>()
                .Property(e => e.StartLocation)
                .IsUnicode(false);

            modelBuilder.Entity<RaceEventTeam>()
                .Property(e => e.EndLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Regatta>()
                .Property(e => e.RegattaName)
                .IsUnicode(false);

            modelBuilder.Entity<Regatta>()
                .Property(e => e.RegattaDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Regatta>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Regatta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regatta>()
                .HasMany(e => e.RegattaEntries)
                .WithRequired(e => e.Regatta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegisteredUser>()
                .HasMany(e => e.RegisteredUserSocialEvents)
                .WithRequired(e => e.RegisteredUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegisteredUser>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.RegisteredUser)
                .HasForeignKey(e => e.SkipperId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegisteredUser>()
                .HasMany(e => e.Teams1)
                .WithMany(e => e.RegisteredUsers)
                .Map(m => m.ToTable("RegisteredTeamUsers").MapLeftKey("RegisteredUserId").MapRightKey("TeamId"));

            modelBuilder.Entity<Result>()
                .Property(e => e.ResultTime)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.CalculatedResultTime)
                .IsUnicode(false);

            modelBuilder.Entity<SocialEvent>()
                .Property(e => e.SocialEventType)
                .IsUnicode(false);

            modelBuilder.Entity<SocialEvent>()
                .HasMany(e => e.RegisteredUserSocialEvents)
                .WithRequired(e => e.SocialEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.RaceEventTeams)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Entries)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RegisteredUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}