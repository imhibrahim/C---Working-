using Microsoft.EntityFrameworkCore;

namespace auth.Models
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions option) : base(option) {
        
        }

        public DbSet<Student> users { get; set; }

    }

}
