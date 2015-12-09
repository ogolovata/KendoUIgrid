using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class PageViewMetadataContext : DbContext
    {
        public PageViewMetadataContext()
            : base("name=PageViewMetadataContext")
        {
        }
        public DbSet<PageViewMetadata> PageViewMetadata { get; set; }
    }
}
