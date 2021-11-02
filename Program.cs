using System;


namespace console_type_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console");


            //Console.ReadLine();
            Console.ReadKey()
        }
    }
}


namespace console_type_system.departments
{
    public interface IEmployee
    {

    }
}


namespace console_type_system.departments
{
    public class Employee
    {
        private int id;

        private string firstName;
        private string lastName;

        private DateTime birthDay;

        private string email;

        private int numberOfHoursWorked;

        private double wage;
        private double? hourlyRate;

        public static double taxRate = 0.15;

        

    }
}


namespace console_type_system.departments
{
    public class Manager : Employee
    {

    }
}


namespace console_type_system.departments
{
    public class StoreManager : Employee
    {

    }
}


namespace console_type_system.departments
{
    public class Researcher : Employee
    {

    }
}


namespace console_type_system.departments
{
    public class Developer : Employee
    {

    }

    //public class JuniorDeveloper : Developer
}

