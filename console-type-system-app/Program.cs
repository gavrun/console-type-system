using System;
using System.Collections.Generic;

namespace console_type_system_app
{
    internal class Program
    {
        private static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.WriteLine("***** Console Type System App *****");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("***********************************");
                Console.WriteLine("******** Select an action *********");
                Console.WriteLine("***********************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Register employee");
                Console.WriteLine("2: Register work hours for employee");
                Console.WriteLine("3: Pay employee");
                Console.WriteLine("9: Quit application");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        RegisterEmployee();
                        break;
                    case "2":
                        RegisterWork();
                        break;
                    case "3":
                        PayEmployee();
                        break;
                    case "9": break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }

            } while (userSelection != "9");

            Console.WriteLine("Thanks for using the application");
            Console.Read();
        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("Creating an employee");
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = new Employee(firstName, lastName, rate);
            employees.Add(employee);

            Console.WriteLine("Employee created!\n\n");
        }

        private static void RegisterWork()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of hours worked: ");
            int hours = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees[selection - 1];
            int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
            
            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked {numberOfHoursWorked} hours in total.\n\n");
        }

        private static void PayEmployee()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees[selection - 1];
            int hoursWorked;
            double receivedWage = selectedEmployee.ReceiveWage(out hoursWorked);

            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of {receivedWage}. The hours worked is reset to {hoursWorked}.\n\n");
        }
    }
}

namespace console_type_system_app
{
    public class Employee
    {
        private string firstName;
        private string lastName;

        private int numberOfHoursWorked;

        private double wage;
        private double hourlyRate;

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public double HourlyRate { get { return wage; } set { wage = value; } }

        public int NumberOfHoursWorked { get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; } }

        public double Wage  { get { return wage; } set { wage = value; } }

        public Employee(string first, string last, double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;
        }

        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }

        public double ReceiveWage(out int hoursWorked)
        {
            Wage = NumberOfHoursWorked * HourlyRate;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }
    }
}