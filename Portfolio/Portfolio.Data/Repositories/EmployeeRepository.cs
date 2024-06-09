using Portfolio.Core.Entities;
using Portfolio.Core.Repositories;
using Portfolio.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(PortfolioDbContext context) : base(context){}
    }
}
