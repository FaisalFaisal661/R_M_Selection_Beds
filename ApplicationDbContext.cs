using Microsoft.EntityFrameworkCore;
using R_M_Selection_Beds.Models;

namespace R_M_Selection_Beds.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactFormModel> ContactForms { get; set; }
    }
}
