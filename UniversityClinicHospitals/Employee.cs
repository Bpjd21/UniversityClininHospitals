using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        public Employee(string name, int employeeID, int salary, bool paid)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
            paid = false;
        }
        public List<Employee> employees { get; set; }

        public Employee()
        {

            employees = new List<Employee>()
            {
                new Doctor("Dr Duer", 123, 90000, true),
                new Nurse("Nurse Brian", 456, 50000, true),
                new Receptionist("Mrs. Duer", 789, 45000, false),
                new Janitor("Mr. Duer", 101, 40000, true),
                
            };

        }

        public void PrintEmployees()
        {
            
            Console.WriteLine("\tName            Employee ID    Salary    Was Paid Salary\n");
            for (int i = 0; i < employees.Count; i++)
            {
                

                Console.WriteLine("      {1}      {2}       {3}      {4}   ",
                    i.ToString(),
                    employees[i].Name.ToString().PadRight(15),
                    employees[i].EmployeeID.ToString().PadRight(5),
                    employees[i].Salary.ToString().PadRight(8),
                    employees[i].Paid = false);
                    
            }
        }



        public virtual void PaySalary()
        {

        }
        

    }
}
