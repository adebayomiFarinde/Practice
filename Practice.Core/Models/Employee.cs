using Practice.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Models
{

    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public int NumberOfChildren { get; set; }
        public bool IsActive { get; set; }
        public virtual DateTime LastDateOfPromotion { get; set; }
        public virtual EducationalQualification MaximumEducationalQualification { get; set; }
       // public List<Team> project { get; set; }
    }
}
