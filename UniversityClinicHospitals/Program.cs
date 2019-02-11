using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityClinicHospitals
{
    class Program
    {
        //private static Employee employees = new Employee();
        static void Main(string[] args)
        {

            Employee employees = new Employee();

            Console.WriteLine("\t\t\tWelcome to Univertiy Clinic" +
                "\n\n\n\t\tPress 1 to view all your employees" +
                "\n\t\tPress 2 to view current patients in hospital");
            Console.WriteLine();
            bool running = true;

            while (running)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\t\t\tCurrent employees at University Clinic\n");
                        employees.PrintEmployees();
                        break;

                }
            }

        }    

        static void PrintAllEmployees()
        {
            PrintAllEmployees();
        }
       
        

        
    }
}
