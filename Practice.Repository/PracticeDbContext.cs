using Microsoft.EntityFrameworkCore;
using Practice.Core.Models;

namespace Practice.Repository
{
    public class PracticeDbContext : DbContext
    {
       public PracticeDbContext(DbContextOptions<PracticeDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            /*modelBuilder.Entity<Team>()
                .HasKey(p => new { p.EmployeeId, p.ProjectId });

            modelBuilder.Entity<Team>()
                .HasOne(x => x.employee)
                .WithMany(t => t.project)
                .HasForeignKey(z => z.EmployeeId);

            modelBuilder.Entity<Team>()
                .HasOne(x => x.project)
                .WithMany(y => y.employee)
                .HasForeignKey(z => z.ProjectId);*/

                
        }
    }
    
}
