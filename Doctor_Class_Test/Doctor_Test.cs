using System;
using Xunit;
using System.Collections.Generic;
using UniversityClinicHospitals;

namespace Doctor_Class_Test
{
    public class Doctor_Test
    {
        [Fact]
        public void Can_Create_Doctor()
        {
            var doctor = new Doctor("Bob", "Hear", 123, 30000);
            doctor.AddDoctor();
            Assert.Equal("Doc", doctor.doctor[0].Name);
        }
    }
}
