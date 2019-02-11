using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityClinicHospitals
{
    public class Program
    {        
        static Employee employees = new Employee();       
        
        static Patient sickies = new Patient();
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("\t\tWelcome to University Clinic Hospitals\n\n");
            Console.WriteLine("\t\tPress 1 to view all employees of hospital");
            Console.WriteLine("\t\tPress 2 to see all patients in hospital");
            Console.WriteLine("\t\tPress 0 to exit program");
            Console.WriteLine();

            string userInput = (Console.ReadLine());

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    employees.PrintEmployees();
                    ESubmenu(employees);
                break;                
                case "2":
                    sickies.PrintPatients();
                    PSubmenu(sickies);
                    break;                    
                case "0":
                    Environment.Exit(0);
                    break;

            }
        }

        static void PSubmenu(Patient patient)
        {
            Console.WriteLine("\n\nPress 1 to have Doctor treat patients blood levels" +
                "\nPress 2 to have Doctor treat health levels" +
                "\nPress 3 to have nurse treat blood levels" +
                "\nPress 4 to have nurse treat health levels" +
                "\nPress 0 to return to main memu ");
            bool running = true;
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("The Doctor has treated" +sickies.Name + "'s blood levels");
                        break;
                    case "2":
                        Console.WriteLine("The Doctor has treated {0} 's health levels", sickies.Name);
                        sickies.DoctorIncreaseHealthLevel();
                        break;
                    case "3":
                        Console.WriteLine("The nurse has treated the patients blood level");
                        sickies.NurseIncreaseBloodLevel();
                        break;
                    case "4":
                        Console.WriteLine("The nurse has treated the patients health levels");
                        sickies.NurseIncreaseHealthLevel();
                        break;
                    case "0":
                        Console.Clear();
                        MainMenu();
                        break;


                }
            } while (running);

        }

        static void ESubmenu(Employee employee)
        {
            Console.WriteLine("Press 1 to pay employee" +
                "\nPress 2 to retrun to main memu");
            bool running = true;

            string userInput;
            do
            {
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        employee.PaySalary();
                        break;
                    case "2":
                        Console.Clear();
                        MainMenu();
                        break;


                }
            } while (running);
        }
    }
}
