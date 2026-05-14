using Microsoft.EntityFrameworkCore;

namespace myAPI.model
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }


        public DbSet<Brand> Brand { get; set; }



    }
}

