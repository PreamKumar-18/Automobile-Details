using Microsoft.EntityFrameworkCore;
using TopSpeed.Web.Models;

namespace TopSpeed.Web.Data
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
        }

        public DbSet<Brand> Brand { get; set; }
    }
}
