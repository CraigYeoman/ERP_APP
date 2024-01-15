using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ERP_APP.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<JobType> JobTypes { get; set; }

    }
}