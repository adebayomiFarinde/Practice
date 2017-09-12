using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice.Core.Models;

namespace Practice.Repository
{
    public class PracticeDbContext: DbContext
    {
        public DbSet<Employee> Employees;
        public DbSet<Team> Teams;
        public DbSet<Project> Projects;
    }

}
