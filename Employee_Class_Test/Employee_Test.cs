using System;
using Xunit;
using UniversityClinicHospitals;


namespace UniversityClinicHospitals_Tests
    {
    public class EmployeeTest
    {
        [Fact]
        public void Pay_Salary_Test()
        {
            var employee = new Employee();
            employee.PaySalary();
            Assert.Equal(9000, employee.Salary);
        }
    }
}
