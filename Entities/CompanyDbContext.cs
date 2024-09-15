

using AutoFixture;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var fixture = new Fixture();

            //seed data
            for (int i = 0; i < 10; i++)
            {
                var employee = fixture.Build<Employee>().With(temp => temp.DateOfBirthday, new DateOnly(1995,1,1)).Create();

                modelBuilder.Entity<Employee>().HasData(employee);
                
            }

        }

    }
}
