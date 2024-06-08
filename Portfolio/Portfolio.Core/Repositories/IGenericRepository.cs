using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Repositories
{
    public interface IGenericRepository<T> where T :BaseEntity , new()
    {
        public DbSet<T> Table { get; }
        public Task CreateAsync(T entity);
        public void Delete(T entity);
        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? expression, params string[]? includes);
        public Task<T> Get(Expression<Func<T, bool>>? expression, params string[]? includes);
        public Task<int> CommitAsync();
    }
}
