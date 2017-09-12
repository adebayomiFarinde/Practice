using Practice.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Core.Models;

namespace Practice.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
