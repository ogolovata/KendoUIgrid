using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class MapMetadataContext : DbContext
    {
        public MapMetadataContext()
            : base("name=MapMetadataContext")
        {
        }
        public DbSet<MapMetadata> MapMetadata { get; set; }
    }
}
