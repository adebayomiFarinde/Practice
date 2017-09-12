using Practice.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Core.Models
{

    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public Sex Sex { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int NumberOfChildren { get; set; }
        public bool IsActive { get; set; }
        public Position Position { get; set; }
        public DateTime LastDateOfPromotion { get; set; }
        public int Salary { get; set; }
        public string MaximumEducationalQualification { get; set; }
        public int TimeOfService { get; set; }
    }
}
