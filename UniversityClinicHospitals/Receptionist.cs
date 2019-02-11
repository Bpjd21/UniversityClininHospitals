using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    class Receptionist : Employee
    {
            public bool IsOnPhone;
        public Receptionist(string name, int employeeID, int salary, bool wasPaid)
        {
        }

        public override void PaySalary()
            {
                if (WasPaid == false)
                {
                    WasPaid = true;
                    Console.WriteLine(Name + " was paid their salary of 45000");
                }else Console.WriteLine("Employee has already been paid, nice try");
        }

            public void AreTheyOnPhone()
            {
                if(IsOnPhone == false)
            {
                IsOnPhone = true;
                Console.WriteLine(Name + " is on the phone");
            }
            }


            public void PrintReceptionist()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine(Name + " " + IsOnPhone);
                Console.WriteLine("Employee ID is: " + EmployeeID);
                Console.WriteLine("Yearly Salary: " + Salary);
                Console.WriteLine(WasPaid);
            }
        }
}
