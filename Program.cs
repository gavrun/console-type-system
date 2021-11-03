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
            //start

            //Console.WriteLine("Console App");

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

            //E




            //Q

            //Manager mary = new Manager(748, "Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30); //correct argements order?

            //StoreManager bethany = new StoreManager(55156, "Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            //StoreManager kevin = new StoreManager(81131, "Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            //StoreManager kate = new StoreManager(100, "Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            //JuniorResearcher bobJunior = new JuniorResearcher(11231, "Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

            //R

            //mary.AttendManagementMeeting();

            //T

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

            //end

            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}


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

