using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class EventMetadataContext : DbContext
    {
        public EventMetadataContext()
            : base("name=EventMetadataContext")
        {
        }
        public DbSet<EventMetadata> EventMetadata { get; set; }
    }
}
