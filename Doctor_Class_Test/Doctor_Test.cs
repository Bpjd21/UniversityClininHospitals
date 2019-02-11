using System;
using Xunit;
using System.Collections.Generic;
using UniversityClinicHospitals;

namespace Doctor_Class_Test
{
    public class Doctor_Test
    {
        [Fact]
        public void DoctorWasPaidTest()
        {
            var newDoctor = new Doctor();
            newDoctor.PaySalary();
            Assert.True(newDoctor.WasPaid);
        }



    }
}
