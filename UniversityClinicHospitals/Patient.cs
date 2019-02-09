using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Patient
    {
        public int Blood_Level;
        public int Health_Level;
                
        public Patient()
        {
            Blood_Level = 80;
            Health_Level = 80;
        }

        public void IncreaseBloodLevel()
        {
            if (Blood_Level <= 80)
            {
                Blood_Level += 20;
            }
            else return;
        }

        public void IncreaseHealthLevel()
        {
            if (Health_Level <= 80)
            {
                Health_Level = +20;
            }
            else return;
        }

    }
}
