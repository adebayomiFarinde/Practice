using Practice.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
