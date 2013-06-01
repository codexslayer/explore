using System.Data.Entity;

namespace Explore.Models
{
    public class ExploreDb : DbContext
    {
        public ExploreDb()
            : base("name=defaultconnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}