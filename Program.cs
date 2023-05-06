using System;
namespace LabAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Employee employee = new Employee();
            Employee staff = new Staff();

            var staff1 = new Staff();

            Teacher teacher1 = new Teacher();

            Director director1 = new Director();


            employee.InterfaceMessage();

            employee.StaticBinding();
            staff.StaticBinding();

            employee.DynamicBinding();
            staff.DynamicBinding();


            Console.WriteLine("Enter a password to be hashed: ");
            director1.Password = Console.ReadLine();
            Console.WriteLine(director1.GetHashedPassword(director1));

           teacher1.TeacherLogIn();
           staff1.StaffLogIn();


        }

    }
}