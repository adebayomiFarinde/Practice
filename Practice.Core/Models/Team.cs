using Practice.Core.Enums;
using System;

namespace Practice.Core.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid EmployeeId { get; set; }  
        public Role Role { get; set; }
    }
}
