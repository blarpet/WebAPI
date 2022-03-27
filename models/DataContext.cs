using Microsoft.EntityFrameworkCore;

namespace WEBAPI.models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Post> posts {get; set;}

    }
}