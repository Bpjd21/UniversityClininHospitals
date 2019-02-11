using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    class Janitor : Employee
    {

        public bool IsSweeping;
        public Janitor(string name, int employeeID, int salary, bool wasPaid)
        {

        }
     
        public override void PaySalary()
        {
            if (WasPaid == false)
            {
                WasPaid = true;
                Console.WriteLine(Name + " was paid their salary of 40000");
            }else Console.WriteLine("Employee has already been paid, nice try");
        }

        public void AreTheySweeping()
        {
            if (IsSweeping == false)
            {
                IsSweeping = true;
                Console.WriteLine(Name + " is currently sweeping");
            }            
        }


        public void PrintJanitor()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine(Name + " " + IsSweeping);
            Console.WriteLine("Employee ID is: " + EmployeeID);
            Console.WriteLine("Yearly Salary: " + Salary);
            Console.WriteLine(WasPaid);
        }
    }
}
