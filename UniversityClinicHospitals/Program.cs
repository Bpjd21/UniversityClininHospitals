using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityClinicHospitals
{
    class Program
    {
        private static Employee employees = new Employee();
        static void Main(string[] args)
        {
            Employee employees = new Employee();
            Menu(employees);        
        }   
            
        static void Menu(Employee employee)
        {
            Console.WriteLine("\t\t\tWelcome to University Clinic Hospitals\n\n\n" +
                "Press 1 to view list of employees\n" +
                "Press 2 to view list of current patients\n\n");
            bool running = true;

            while (running)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();                        
                        employee.PrintAllEmployees();
                        break;
                    default:
                        break;

                }



            }

        }
        

        
    }
}
