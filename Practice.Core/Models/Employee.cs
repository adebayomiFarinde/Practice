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
        public DateTime DateOfEmployment { get; set; }
        public Sex Sex { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int NumberOfChildren { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastDateOfPromotion { get; set; }
        public EducationalQualification MaximumEducationalQualification { get; set; }
    }
}
