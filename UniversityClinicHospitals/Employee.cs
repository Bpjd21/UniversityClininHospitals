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
        public bool WasPaid { get; set; }

        public Employee(string name, int employeeID, int salary, bool wasPaid)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
            WasPaid = wasPaid;
        }

        public List<Employee> employees;

        public Employee()
        {
            employees = new List<Employee>()
            {
                new Doctor("Dr Duer", 123, 90000, true),
                new Nurse("Nurse Brian", 456, 50000, false),
                new Janitor("Mr. Duer", 678, 45000, true),
                new Receptionist("Mrs. Duer", 111, 40000, true)
                
            };
        }

        public void PrintAllEmployees()
        {
            string type = "";
            Console.WriteLine("\tName           EmployeeID      Salary        Was Paid This Year");
            for (int i = 0; i < employees.Count; i++)
            {
                //if (employees[i].GetType() == typeof(Doctor))
                //{
                //    type = "Doctor";
                //}
                //else if (employees[i].GetType() == typeof(Nurse))
                //{
                //    type = "Nurse";
                //}
                Console.WriteLine("     {1}         {2}       {3}               {4}  ",
                    i.ToString().PadRight(2),
                    employees[i].Name.PadRight(12).ToString(),
                    employees[i].EmployeeID,                   
                    employees[i].Salary,
                    employees[i].WasPaid,
                    type.ToString());
            }
            

        }    

        public virtual void PaySalary()
        {
            WasPaid = false;
        }

            
    }
}
