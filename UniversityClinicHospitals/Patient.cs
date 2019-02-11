using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    
    public class Patient
    {
        public int Blood_Level { get; private set; }
        public int Health_Level { get; private set; }
        public string Name { get; private set; }

        public Patient()
        {
            Blood_Level = 20;
            Health_Level = 10;
            Name = "Sickie Duer";
        }

        public List<Patient> sickie = new List<Patient>();
        

        public void DoctorIncreaseBloodLevel()
        {
            if (Blood_Level <= 80)
            {
                Blood_Level += 20;
            }
            else return;
        }

        public void DoctorIncreaseHealthLevel()
        {
            if (Health_Level <= 80)
            {
                Health_Level = +50;
            }
            else return;
        }

        public void NurseIncreaseBloodLevel()
        {
            if (Blood_Level <= 80)
            {
                Blood_Level += 40;
            }
            else return;
        }

        public void NurseIncreaseHealthLevel()
        {
            if (Health_Level <= 80)
            {
                Health_Level = +20;
            }
            else return;
        }

    }
}
