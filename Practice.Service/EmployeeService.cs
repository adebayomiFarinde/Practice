﻿using Practice.Core.Interfaces;
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

        public Task<Employee> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _employeeRepository.GetAll();
        }

        public Task<Employee> SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
