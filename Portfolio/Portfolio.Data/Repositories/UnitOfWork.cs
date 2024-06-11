using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Repositories;
using Portfolio.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortfolioDbContext _context;
        private  IEmployeeRepository _employeeRepository;
        public IEmployeeRepository Employees
        {
            get { return _employeeRepository ??= new EmployeeRepository(_context); }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
