using Microsoft.EntityFrameworkCore;

namespace MVC_API.Model
{
    public class StuDBContext : DbContext
    {
        public StuDBContext(DbContextOptions<StuDBContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
