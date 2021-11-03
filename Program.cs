using System;
using System.Collections.Generic;
//add namespace
using console_type_system.departments;


namespace console_type_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":-)");
            //part I

            //A

            //int monthlyWage = 1234;
            //double ratePerHour = 12.34;
            //int numberOfHoursWorked = 165;
            //int bonus = 1000;

            //double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            //ratePerHour += 3;
            //Console.WriteLine(ratePerHour);

            //if (currentMonthWage > 2000)
            //{
            //    Console.WriteLine("Top paid employee");
            //}

            //Console.WriteLine(currentMonthWage);

            //B

            //char userSelection = 'a';
            //char upperVersion = char.ToUpper(userSelection);
            //bool isDigit = char.IsDigit(userSelection);
            //bool isLetter = char.IsLetter(userSelection);

            //C

            //DateTime hireDate = new DateTime(2012, 3, 28, 14, 30, 0);
            //DateTime invalidDate = new DateTime(2021, 15, 11);

            //Console.WriteLine(hireDate);

            //DateTime startDate = hireDate.AddDays(15);

            //Console.WriteLine(startDate);

            //D

            //var currentDate = DateTime.Now;
            //bool areWeInDst = currentDate.IsDaylightSavingTime();

            //DateTime startHour = DateTime.Now;
            //TimeSpan workTime = new TimeSpan(8, 35, 0);
            //DateTime endHour = startHour.Add(workTime);

            //Console.WriteLine(startHour);
            //Console.WriteLine(endHour);

            //Console.WriteLine(startHour.ToLongDateString());
            //Console.WriteLine(endHour.ToShortTimeString());

            //part II

            //private static List<Employee> employees = new List<Employee>();
            //static void Main(string[] args)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("***********************************");
            //    Console.WriteLine("************Employee**App**********");
            //    Console.WriteLine("***********************************");
            //    Console.ForegroundColor = ConsoleColor.White;

            //    string userSelection;

            //    do
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;

            //        Console.WriteLine("********************");
            //        Console.WriteLine("* Select an action *");
            //        Console.WriteLine("********************");
            //        Console.ForegroundColor = ConsoleColor.White;

            //        Console.WriteLine("1: Register employee");
            //        Console.WriteLine("2: Register work hours for employee");
            //        Console.WriteLine("3: Pay employee");
            //        Console.WriteLine("9: Quit application");

            //        userSelection = Console.ReadLine();

            //        switch (userSelection)
            //        {
            //            case "1":
            //                RegisterEmployee();
            //                break;
            //            case "2":
            //                RegisterWork();
            //                break;
            //            case "3":
            //                PayEmployee();
            //                break;
            //            case "9": break;
            //            default:
            //                Console.WriteLine("Invalid selection. Please try again.");
            //                break;
            //        }
            //    }
            //    while (userSelection != "9");

            //    Console.WriteLine("Thanks for using the application");
            //    Console.Read();

            //    static void RegisterEmployee() //static modifier is not permitted on a local function?
            //    {
            //        Console.WriteLine("Creating an employee");

            //        Console.Write("Enter the first name: ");
            //        string firstName = Console.ReadLine();

            //        Console.Write("Enter the last name: ");
            //        string lastName = Console.ReadLine();

            //        Console.Write("Enter the hourly rate: ");
            //        string hourlyRate = Console.ReadLine();

            //        double rate = double.Parse(hourlyRate); //assuming that input is in a correct format

            //        Employee employee = new Employee(firstName, lastName, rate);
            //        employees.Add(employee);

            //        Console.WriteLine("Employee created!\n\n");

            //    }

            //    static void RegisterWork()
            //    {
            //        Console.WriteLine("Select an employee");

            //        for (int i = 1; i <= employees.Count; i++)
            //        {
            //            Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            //        }

            //        int selection = int.Parse(Console.ReadLine()); //assuming that that a valid ID is selected

            //        Console.Write("Enter the number of hours worked: ");
            //        int hours = int.Parse(Console.ReadLine()); //assuming that that a valid amount is entered

            //        Employee selectedEmployee = employees[selection - 1];
            //        int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
            //        Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked {numberOfHoursWorked} hours in total.\n\n");
            //    }

            //    static void PayEmployee()
            //    {
            //        Console.WriteLine("Select an employee");

            //        for (int i = 1; i <= employees.Count; i++)
            //        {
            //            Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            //        }

            //        int selection = int.Parse(Console.ReadLine()); //assuming that that a valid ID is selected

            //        Employee selectedEmployee = employees[selection - 1];
            //        int hoursWorked;
            //        double receivedWage = selectedEmployee.ReceiveWage(out hoursWorked);

            //        Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of {receivedWage}. The hours worked is reset to {hoursWorked}.\n\n");
            //    }

            //part III

            //A

            //Employee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25); //correct argements order?
            //Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            //JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            //Employee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            //Employee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.ReceiveWage();
            //bethany.DisplayEmployeeDetails();

            //mary.PerformWork();
            //mary.PerformWork();
            //mary.PerformWork();
            //mary.AttendManagementMeeting();
            //mary.ReceiveWage();
            //mary.DisplayEmployeeDetails();

            //bobJunior.ResearchNewPieTastes(5);
            //bobJunior.ReceiveWage();
            //bobJunior.DisplayEmployeeDetails();

            //B

            //Employee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25); //correct argements order?
            //Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            //JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            //Employee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            //Employee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            //Employee[] employees = new Employee[5];
            //employees[0] = bethany;
            //employees[1] = mary;
            //employees[2] = bobJunior;
            //employees[3] = kevin;
            //employees[4] = kate;

            //foreach (var employee in employees)
            //{
            //    employee.PerformWork();
            //    employee.ReceiveWage();
            //    employee.DisplayEmployeeDetails();
            //    employee.GiveBonus();
            //    //employee.AttendManagementMeeting();
            //}

            //C

            //Manager mary = new Manager(748, "Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30); //correct argements order?

            //StoreManager bethany = new StoreManager(55156, "Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            //StoreManager kevin = new StoreManager(81131, "Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            //StoreManager kate = new StoreManager(100, "Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            //JuniorResearcher bobJunior = new JuniorResearcher(11231, "Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

            //List<IEmployee> employees = new List<IEmployee>();
            //employees.Add(mary);
            //employees.Add(bethany);
            //employees.Add(kevin);
            //employees.Add(kate);
            ////employees.Add(bobJunior);

            //employees.Sort();

            //foreach (var employee in employees)
            //{
            //    employee.DisplayEmployeeDetails(); 
            //}

            Console.ReadKey(); //Console.ReadLine();
        }
    }
}


//class for part II

//namespace console_type_system
//{
//    public class Employee
//    {
//        private string firstName;
//        private string lastName;

//        private int numberOfHoursWorked;
//        private double wage;
//        private double hourlyRate;

//        public string FirstName
//        {
//            get { return firstName; }
//            set
//            {
//                firstName = value;
//            }
//        }

//        public string LastName
//        {
//            get { return lastName; }
//            set
//            {
//                lastName = value;
//            }
//        }

//        public double HourlyRate
//        {
//            get { return hourlyRate; }
//            set
//            {
//                hourlyRate = value;
//            }
//        }

//        public int NumberOfHoursWorked
//        {
//            get { return numberOfHoursWorked; }
//            set
//            {
//                numberOfHoursWorked = value;
//            }
//        }

//        public double Wage
//        {
//            get { return wage; }
//            set
//            {
//                wage = value;
//            }
//        }

//        public Employee(string first, string last, double rate)
//        {
//            FirstName = first;
//            LastName = last;
//            HourlyRate = rate;
//        }

//        public int PerformWork(int hours)
//        {
//            NumberOfHoursWorked += hours;
//            return NumberOfHoursWorked;
//        }

//        public double ReceiveWage(out int hoursWorked)
//        {
//            Wage = NumberOfHoursWorked * HourlyRate;

//            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

//            NumberOfHoursWorked = 0;
//            hoursWorked = NumberOfHoursWorked;

//            return Wage;
//        }
//    }
//}



//new namespace
namespace console_type_system.departments
{
    public interface IEmployee
    {
        void PerformWork();
        void StopWorking();
        double ReceiveWage();
        void GiveCompliment();
        void GiveBonus();
        void DisplayEmployeeDetails();
    }
}


//base class
namespace console_type_system.departments
{
    //public abstract class Employee
    public class Employee : IComparable, IEmployee
    {
        //class fields
        private int id;

        private string firstName;
        private string lastName;

        private DateTime birthDay;

        private string email;

        private int numberOfHoursWorked;

        private double wage;
        private double? hourlyRate;

        public static double taxRate = 0.15; //const

        //private EmployeeType employeeType;

        //private const double maxAmountHoursWorked = 1000;

        //properties
        public int Id
        {
            get 
            { 
                return id;
            }
            set 
            { 
                id = value;
            }
        }

        public string FirstName
        {
            get { return firstName; } set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; } set { birthDay = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; } set { wage = value; }
        }

        private double? HourlyRate
        {
            get { return hourlyRate; } set { hourlyRate = value; }
        }

        //public EmployeeType EmployeeType
        //{
        //    get { return employeeType; }
        //    set
        //    {
        //        employeeType = value;
        //    }
        //}

        //constructor
        public Employee()
        { }

        //constructor and overloading
        public Employee(int empId, string first, string last, DateTime bd, string em, double? rate)
        {
            Id = empId;
            FirstName = first;
            LastName = last;
            BirthDay = bd;
            Email = em;
            HourlyRate = rate ?? 10; //default
            //maxAmountHoursWorked = 100; //valude not allowed
        }

        //methods enforced by interface
        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        //public abstract double ReceiveWage();
        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You've done a great job, {FirstName}");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nID: {Id}\nFirst name: {FirstName}\nLast name: {LastName}\nBirthday: {BirthDay.ToShortDateString()}\nEmail: {Email}\nTax rate: {taxRate}");
            //Employee type: {EmployeeType}\n
            //remove Tax rate: {taxRate}
        }

        //enumeration
        //public enum EmployeeType
        //{
        //    Employee,
        //    Manager,
        //    StoreManager,
        //    Researcher,
        //    Developer
        //}


        //polymorphic method
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        //another interface?
        public int CompareTo(object obj)
        {
            var otherEmployee = (Employee)obj;

            if (Id > otherEmployee.Id)
            {
                return 1;
            }
            else if (Id < otherEmployee.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}


//derived class
namespace console_type_system.departments
{
    public class Manager : Employee
    {
        //class fields
        //properties

        //constructors
        public Manager(int empId, string first, string last, DateTime bd, string em, double? rate) : base(empId, first, last, bd, em, rate) //base-class constructor
        { }
        
        //methods
        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;

            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting!");
        }

        //polymorphic method derived
        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
            }
        }
    }
}


namespace console_type_system.departments
{
    public class StoreManager : Employee
    {
        public StoreManager(int empId, string first, string last, DateTime bd, string em, double? rate) : base(empId, first, last, bd, em, rate)
        { }
    }
}


namespace console_type_system.departments
{
    public class Researcher : Employee
    {
        //class fields
        //properties
        //constructors
        public Researcher(int empId, string first, string last, DateTime bd, string em, double? rate) : base(empId, first, last, bd, em, rate)
        { }
        //methods
        public void ResearchNewThing(int researchHours)
        {
            NumberOfHoursWorked += researchHours;

            Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new thing!");
        }

        //child class
        public class JuniorResearcher : Researcher
        {
            public JuniorResearcher(int empId, string first, string last, DateTime bd, string em, double? rate) : base(empId, first, last, bd, em, rate)
            { }
        }
    }
}


namespace console_type_system.departments
{
    public class Developer : Employee
    {
        public Developer(int empId, string first, string last, DateTime bd, string em, double? rate) : base(empId, first, last, bd, em, rate)
        { }
    }
    //child class cannot be derived from sealed class
    //public class JuniorDeveloper : Developer
    //{
    //    public JuniorDeveloper(int empId, string first, string last, DateTime bd, string em, double? rate) : base(empId, first, last, bd, em, rate)
    //    { }

    //}
}


//namespace console_type_system.departments.accounting
//{
//    public class Account
//    {
//        private string accountNumber;

//        public string AccountNumber
//        {
//            get { return accountNumber; } 
//            set
//            {
//                accountNumber = value;
//            }
//        }
//    }
//}


//namespace console_type_system.departments.accounting
//{
//    public class Customer
//    {
//        private string customerId;
//        private string name;

//        public string CustomerId
//        {
//            get { return customerId; }
//            set
//            {
//                customerId = value;
//            }
//        }
//        public string Name
//        {
//            get { return name; }
//            set
//            {
//                name = value;
//            }
//        }
//    }
//}

