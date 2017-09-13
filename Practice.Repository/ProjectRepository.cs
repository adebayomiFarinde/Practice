using Microsoft.EntityFrameworkCore;
using Practice.Core.Interfaces;
using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly PracticeDbContext _dbContext;
        public ProjectRepository(PracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Project>> GetAll()
        {
           return await _dbContext.Projects.ToListAsync();
        }

        public async Task<Project> Get(Guid id)
        {
            return await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Delete(Project project)
        {
            _dbContext.Entry(project).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Project project)
        {
            _dbContext.Entry(project).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Create(Project project)
        {
            _dbContext.Entry(project).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }
    }
}
