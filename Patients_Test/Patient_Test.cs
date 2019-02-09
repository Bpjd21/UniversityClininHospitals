using System;
using Xunit;
using UniversityClinicHospitals;

namespace Patients_Test
{
    public class Patient_Test
    {
        [Fact]
        public void IncreaseBloodLevelTest()
        {
            var sickie = new Patient();
            sickie.IncreaseBloodLevel();
            Assert.Equal(100, sickie.Blood_Level);
        }
    }
}
