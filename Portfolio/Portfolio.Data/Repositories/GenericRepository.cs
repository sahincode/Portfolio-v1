using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories;
using Portfolio.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity ,new()
    {
        private  readonly PortfolioDbContext _context;
       
        public GenericRepository(PortfolioDbContext context)
        {
            this._context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
            
        }

        public  async Task CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public async  Task<T> Get(Expression<Func<T, bool>>? expression, params string[]? includes)
        {
            var query = this.GetQuery(includes);
            return expression is not null ? await query.Where(expression).FirstOrDefaultAsync() : await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? expression, params string[]? includes)
        {
            var query = this.GetQuery(includes);
            return expression is not null ? await query.Where(expression).ToListAsync() : await query.ToListAsync();
        }
        public IQueryable<T> GetQuery(params string[] includes)
        {
            var query = Table.AsQueryable();
            if (includes is not null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query;
        }
    }
}
