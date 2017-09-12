using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Core.Interfaces
{
    public interface IEmployeeServiceInterface
    {
        Task<IEnumerable<Employee>> GetAll();
    }
}
