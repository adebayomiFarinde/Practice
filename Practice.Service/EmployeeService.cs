using Practice.Core.Interfaces;
using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Get(Guid id)
        {
            return await _employeeRepository.Get(id);
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task<Employee> SaveEmployee(Employee employee)
        {
            await _employeeRepository.Create(employee);

            return employee;
        }
    }
}
