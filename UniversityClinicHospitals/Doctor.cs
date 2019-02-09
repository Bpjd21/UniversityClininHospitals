using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Doctor : Employee
    {
        public string Specialty { get; private set; }

        public List<Doctor> doctor { get; set; }
        public Doctor(string name, string specialty, int employeeID, int salary)
        {
            doctor = new List<Doctor>()
            {
                new Doctor("Dr. Bob", "CardioVascular", 123, 9000)
            };

        }

        public void AddDoctor()
        {
           var doctor = new List<Doctor>();
        }
       
    }
}
