using Practice.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Core.Models
{
    public class Team
    { 
        public Guid ProjectId { get; set; }
        //public Project project { get; set; }
        public Guid EmployeeId { get; set; }
        //public Employee employee { get; set; }
        public Role Role { get; set; }
    }
}
