using Practice.Core.Enums;
using Practice.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Tests.Helpers
{
    public static class MockData
    {
        public static IEnumerable<Guid> ids = new List<Guid>
        {
            Guid.Parse("176CE848-2438-4590-BE9B-11C89D78BA36"),
            Guid.Parse("{176CE848-2438-4590-BE9B-11C89D78BA36}")
        };
        public static IEnumerable<Employee> employeeDb = new List<Employee>
        {
            new Employee { Id = ids.First(), FirstName = "Akin", LastName = "Alabi", Sex = Sex.Male, DateOfBirth = new DateTime(1986, 2, 12) },
            new Employee { Id = ids.First(), FirstName = "Mimi", LastName = "Coker", Sex = Sex.Female, DateOfBirth = new DateTime(1983, 6, 5) }
        };
    }
}
