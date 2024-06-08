using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.DAL
{
    public class PortfolioDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public PortfolioDbContext(DbContextOptions options):base(options){}
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                var entity = entry.Entity;

                if (entity != null)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entity.CreationTime = DateTime.UtcNow.AddHours(4);
                            break;
                        case EntityState.Modified:
                            entity.UpdateTime = DateTime.UtcNow.AddHours(4);

                            break;

                        case EntityState.Detached:
                            entity.UpdateTime = DateTime.UtcNow.AddHours(4);

                            break;
                        case EntityState.Unchanged:
                            break;

                    }
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
