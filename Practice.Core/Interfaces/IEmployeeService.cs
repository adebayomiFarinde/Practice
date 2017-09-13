using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.Core.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> Get(Guid id);
        Task<Employee> SaveEmployee(Employee employee);
    }
}
