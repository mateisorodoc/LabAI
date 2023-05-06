using System;
using System.Diagnostics.Contracts;
using LabAI;

namespace LabAI
{
    public class Employee : IPerson
    {
        public void InterfaceMessage()
        {
            Console.WriteLine("Message from the IPerson interface");
        }

        //private attributes
        private string _firstName;
        private string _lastName;
        private int _birthYear;
        private double _salary;
        private static int _numberOfEmployees = 0;


        //protected attributes
        protected string _cnp;
        protected string _phoneNumber;
        protected int _departmentId;

        //public prorietes
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int BirthYear { set; get; }
        public double Salary { set; get; }
        public static int NumberOfEmployees { set; get; }

        public string Cnp { set; get; }
        public string PhoneNumber { set; get; }
        public int DepartmentId { set; get; }


        //public attributes
        public string course;
        public string workEmail;

        //protected objects:
        public Contract contract = new Contract();

        //constructors
        public Employee() : this("Default first name", "Default last name", 0.0)
        {
            Console.WriteLine("Construcotr with no params called.");
        }

        public Employee(string _firstName, string _lastName) : this(_firstName, _lastName, 0.0)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;

            Console.WriteLine("SYSTEM MESSAGE: Constructor with 2 params called");
        }

        public Employee(string _firstName, string _lastName, double _salary)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._salary = _salary;

            Console.WriteLine("SYSTEM MESSAGE: Constructor with 3 params called");
        }

        ~Employee()
        {
            Console.WriteLine("SYSTEM MESSAGE: " + _firstName + " was Doomed!");
            --_numberOfEmployees;
        }

        public void StaticBinding()
        {
            Console.WriteLine("Employee::StaticBinding");
        }

        public virtual void DynamicBinding()
        {
            Console.WriteLine("Employee::DynamicBindinf");
        }


        public int GetNumberOfEmployees()
        {
            return _numberOfEmployees;
        }


    }
}