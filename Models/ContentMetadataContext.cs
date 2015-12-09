using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class ContentMetadataContext : DbContext
    {
        public ContentMetadataContext()
            : base("name=ContentMetadataContext")
        {
        }
        public DbSet<ContentMetadata> ContentMetadata { get; set; }
    }
}
