using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        
        public Doctor(string name, int employeeID, int salary) : base(name, employeeID, salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = 90000;
        }
                
        public override void PaySalary()
        {
            if (Paid)
            {
                Console.WriteLine(Name + " was paid their salary of 90000");
            }
            else
            {
                Paid = false;
                Console.WriteLine(Name + " has already been paid, nice try");
            }
            }
 

        public void PrintDoctors()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Specialty: " + Specialty);
            Console.WriteLine("Employee ID is: " + EmployeeID);
            Console.WriteLine("Yearly Salary: " + Salary);
            Console.WriteLine(Paid);
        }

        public void DoctorTreatBlood(Patient sickie)
        {
            sickie.DoctorIncreaseBloodLevel();
            Console.WriteLine("Patient's blood level has increased to "+ sickie.Blood_Level);
            Console.ReadKey();
        }

        public void DoctorTreatHealth(Patient sickie)
        {
            sickie.DoctorIncreaseHealthLevel();
            Console.WriteLine("Patient's health level has increased to " + sickie.Health_Level);
            Console.ReadKey();
        }

    }
}
