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

        //Constructors
        public Patient(string name, int blood_level, int health_level)
        {
            Blood_Level = blood_level;
            Health_Level = health_level;
            Name = name;
        }
        public List<Patient> sickies { get; set; }

        public Patient()
        {
            sickies = new List<Patient>()
            {
                new Patient("Brian", 20, 10),
                new Patient("Billy", 20, 10)

            };
        }
        
        //Methods
        public void PrintPatients()
        {
            Console.Clear();
            Console.WriteLine("\tPatient Name        Blood Level       Health Level\n");
            for (int i = 0; i < sickies.Count; i++)
            {
                Console.WriteLine("          {1}                {2}                 {3}",
                i.ToString(),
                sickies[i].Name.ToString(),
                sickies[i].Blood_Level.ToString(),
                sickies[i].Health_Level.ToString());
            }
        }

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
