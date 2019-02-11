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

        public Employee(string name, int employeeID, int salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;      
        }
        public List<Employee> employees { get; set; }

        public Employee()
        {
            employees = new List<Employee>()
            {
                new Doctor("Dr Duer", 123, 90000),
                new Nurse("Nurse Brian", 456, 50000),
                new Receptionist("Mrs. Duer", 789, 45000),
                new Janitor("Mr. Duer", 101, 40000),                
            };
        }

        public void PrintEmployees()
        {
            Console.WriteLine("\t\t\tCurrent Employees at the Hospital\n\n");
            Console.WriteLine($"\t\tName            Employee ID    Salary        \n");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("               {1}      {2}       {3}           ",
                    i.ToString(),
                    employees[i].Name.ToString().PadRight(15),
                    employees[i].EmployeeID.ToString().PadRight(5),
                    employees[i].Salary.ToString().PadRight(8));
                Console.WriteLine();
            }
        }

        public void isPaid()
        {
            if (Paid == true)
            {
                Console.WriteLine("Y");
            }
            else Console.WriteLine("N");
        }

               
        public virtual void PaySalary()
        {

        }
        

    }
}
