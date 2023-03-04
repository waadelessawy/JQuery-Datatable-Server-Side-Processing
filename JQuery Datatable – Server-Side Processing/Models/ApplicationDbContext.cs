using Microsoft.EntityFrameworkCore;

namespace JQuery_Datatable___Server_Side_Processing.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
         public DbSet<Customer> Customers { get; set; }
    }

   
}
