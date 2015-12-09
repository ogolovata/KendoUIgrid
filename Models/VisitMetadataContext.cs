using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class VisitMetadataContext : DbContext
    {

        public VisitMetadataContext()
            : base("name=VisitMetadataContext")
        {
        }
        public DbSet<VisitMetadata> VisitMetadata { get; set; }
    }
}
