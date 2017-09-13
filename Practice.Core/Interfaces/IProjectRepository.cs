using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Core.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAll();
        Task <Project> Get(Guid id);
        Task Delete (Project project);
        Task Update(Project project);
        Task Create(Project project);
    }
}
