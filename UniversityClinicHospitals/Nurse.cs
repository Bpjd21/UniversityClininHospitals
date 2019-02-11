using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Nurse : Employee
    {
        public int NumberOfPatirntsUnderCare;
        public Nurse(string name, int employeeID, int salary, bool paid) : base(name, employeeID, salary, paid)
        {
            NumberOfPatirntsUnderCare = 3;
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                Paid = true;
                Console.WriteLine(Name + " was paid their salary of 50000");
            }
            else Console.WriteLine("Employee has already been paid, nice try");
        } 

        public void PrintNurses()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine(Name+ " Has " + NumberOfPatirntsUnderCare+ "number of patients under thier car");
            Console.WriteLine("Employee ID is: " + EmployeeID);
            Console.WriteLine("Yearly Salary: " + Salary);
            Console.WriteLine(Paid);
        }

        public void NurseTreatBloodLovel(Patient sickie)
        {
            sickie.NurseIncreaseBloodLevel();
            Console.WriteLine("Nurse helped raise patients blood level to " + sickie.Blood_Level);
            Console.ReadKey();
        }

        public void NurseTreatHealthLevel(Patient sickie)
        {
            sickie.NurseIncreaseHealthLevel();
            Console.WriteLine("Nurse helped raise patients health level to " + sickie.Health_Level);
            Console.ReadKey();
        }
    }
}
