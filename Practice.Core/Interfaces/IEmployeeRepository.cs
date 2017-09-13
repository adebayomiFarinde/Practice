using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();

        Task<Employee> Get(Guid id);

        Task Create(Employee employee);

        Task Update(Employee employee);

        Task Delete(Employee employee);
    }
}
