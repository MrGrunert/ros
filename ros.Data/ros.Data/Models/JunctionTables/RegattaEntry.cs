namespace ros.Data.Models.JunctionTables
{
    public class RegattaEntry
    {
        public int RegattaEntryId { get; set; }

        public int EntryId { get; set; }

        public int RegattaId { get; set; }

        public virtual Entry Entry { get; set; }

        public virtual Regatta Regatta { get; set; }
    }
}