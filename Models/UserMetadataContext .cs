using KendoUIgrid.Models;
using System.Data.Entity;

namespace KendoUIgrid.Models
{
    public class UserMetadataContext : DbContext
    {
        public UserMetadataContext()
            : base("name=UserMetadataContext")
        {
        }
        public DbSet<UserMetadata> UserMetadata { get; set; }
    }
}
