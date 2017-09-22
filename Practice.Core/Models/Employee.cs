using Practice.Core.Enums;
using System;

namespace Practice.Core.Models
{

    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public int NumberOfChildren { get; set; }
        public bool IsActive { get; set; }
    }
}
