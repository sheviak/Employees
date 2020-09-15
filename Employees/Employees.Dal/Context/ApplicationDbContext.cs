using Employees.Core;
using Microsoft.EntityFrameworkCore;

namespace Employees.Dal.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<EmployeePositionInfo> EmployeePositionInfos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmployeePosition>()
                .HasKey(t => t.Id);

            builder.Entity<EmployeePosition>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeePosition)
                .HasForeignKey(x => x.EmployeeId);

            builder.Entity<EmployeePosition>()
                .HasOne(x => x.Position)
                .WithMany(x => x.EmployeePosition)
                .HasForeignKey(x => x.PositionId);

            builder.Entity<EmployeePosition>()
                .HasOne(s => s.EmployeePositionInfo)
                .WithOne(ad => ad.EmployeePosition)
                .HasForeignKey<EmployeePositionInfo>(ad => ad.EmployeePositionId);

            base.OnModelCreating(builder);
        }
    }
}