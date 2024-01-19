using Microsoft.EntityFrameworkCore;

namespace CRUDNet8MVC.Data
{
  public class ApplicationDbContext: DbContext 
  {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        //Models
        public DbSet<Models.Contact> Contacts { get; set; }
    }
}
