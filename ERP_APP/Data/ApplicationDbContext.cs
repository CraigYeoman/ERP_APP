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
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<PartCategory> PartCategories { get; set; }
        public DbSet<Labor> Labors { get; set; }
        public DbSet<LaborCategory> LaborCategories { get; set; }

    }
}