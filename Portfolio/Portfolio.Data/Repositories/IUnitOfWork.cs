using Portfolio.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Repositories
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
        void Commit();
        void RollBack();
        void Dispose();
    }
}
