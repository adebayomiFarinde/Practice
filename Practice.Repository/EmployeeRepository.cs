using Practice.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Practice.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Practice.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PracticeDbContext _dbContext;

        public EmployeeRepository(PracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Employee employee)
        {
           // _dbContext.Employees.Add(employee);
            _dbContext.Entry(employee).State = EntityState.Added;

            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Employee employee)
        {
            //_dbContext.Employees.Remove(employee);
            _dbContext.Entry(employee).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Employee> Get(Guid id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task Update(Employee employee)
        {
            //_dbContext.Employees.Update(employee);
            _dbContext.Entry(employee).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
