using CRUDAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPP.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
