using Portfolio.Business.DTOs.EmployeeModelDTOs;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.Services.Interface
{
    public  interface IEmployeeService
    {
        Task CreateAsync(EmployeeCreateDto entity);
        Task UpdateAsync(EmployeeUpdateDto entity);
        Task Delete(int id);
        Task ToggleDelete(int id);
        Task<Employee> GetById(int? id);
        Task<Employee> Get(Expression<Func<Employee, bool>>? predicate, params string[]? includes);
        Task<IEnumerable<Employee>> GetAll(Expression<Func<Employee, bool>>? predicate, params string[]? include);
    }
}

