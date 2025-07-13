using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserApp.Domain.Core.Home.DTO;
using UserApp.Domain.Core.Home.Entities;
using UserApp.Infra.Data.Db.SqlServer.Ef.Configoration;

namespace UserApp.Infra.Data.Db.SqlServer.Ef.DataDBContaxt
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<SellerUser> SellerUsers { get; set; }
        public DbSet<BuyerUser> BuyerUsers { get; set; }
        public DbSet<WarehouseUser> WarehouseUsers { get; set; }
        public DbSet<AccountantUser> AccountantUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply configurations
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new AdminUserConfiguration());
            builder.ApplyConfiguration(new EmployeeUserConfiguration());
            builder.ApplyConfiguration(new SellerUserConfiguration());
            builder.ApplyConfiguration(new BuyerUserConfiguration());
            builder.ApplyConfiguration(new WarehouseUserConfiguration());
            builder.ApplyConfiguration(new AccountantUserConfiguration());
            builder.ApplyConfiguration(new ApplicationRoleConfiguration());
        }
    }
}
