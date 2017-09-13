using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Practice.Core.Interfaces;
using Practice.Service;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Practice.Tests.Helpers.MockData;

namespace Practice.Tests.Unit
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private static Mock<IEmployeeRepository> _employeeRepository;
        private IEmployeeService _employeeService;

        [ClassInitialize]
        public static void BeforeAll(TestContext context)
        {
            _employeeRepository = new Mock<IEmployeeRepository>();
            _employeeRepository.Setup(x => x.GetAll()).ReturnsAsync(employeeDb);
        }

        [TestInitialize]
        public void BeforeEach()
        {
            _employeeService = new EmployeeService(_employeeRepository.Object);
        }

        [TestMethod]
        public async Task Can_Get_All_Employees()
        {
            var result = await _employeeService.GetAll();

            Assert.AreEqual(result.Count(), 2);
        }

        [TestMethod]
        public async Task Can_Get_An_Employee()
        {
            var id = Guid.NewGuid();
            var employee = await _employeeService.Get(id);

            Assert.AreEqual(employee.FirstName, employeeDb.First().FirstName);
        }
    }
}
