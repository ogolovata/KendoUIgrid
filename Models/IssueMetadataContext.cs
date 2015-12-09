using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class IssueMetadataContext : DbContext
    {
        public IssueMetadataContext()
            : base("name=IssueMetadataContext")
        {
        }
        public DbSet<IssueMetadata> IssueMetadata { get; set; }
    }
}
