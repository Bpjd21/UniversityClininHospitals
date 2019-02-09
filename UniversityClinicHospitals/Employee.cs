using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Employee
    {
        public string Name { get; private set; }
        public int EmployeeID { get; private set; }
        public int Salary { get; private set; }
        public bool WasPaid { get; private set; }

        public Employee(string name, int employeeID, int salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public Employee()
        {
            Console.WriteLine("Basic constructor in employee class is running");
        }

        public virtual void PaySalary()
        {

        }

        public List<Employee> Employees { get; set; }

        public void PrintAllEmployee()
        {
            string type = "";
            Console.WriteLine("ID   Name   blah    blah    blah");
            for(int i = 0; 1 < Employees.Count; i++)
            {
                if (Employees[i].GetType() == typeof(Doctor))
                {
                    type = "Doctor";
                }
                

            }
        }
    }
}
