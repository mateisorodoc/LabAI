using System;
namespace LabAI
{
	public class Teacher : Employee
	{
		public Teacher()
		{
		}

		//private atttributes
		private string _course;
		private string _teacherCode;

		//public proprietes
		public string TeacherCode { set; get; }

        //public objects
		//public methods
		public void SetDepartmentId()
		{
            int departmentId;
            Console.WriteLine("Department id (must be bigger than 10): ");
			string? line = Console.ReadLine();
			departmentId = int.Parse(line);

            while (departmentId < 10)
            {
                Console.WriteLine("Department ID must be BIGGER than 10!: ");
                line = Console.ReadLine();
                departmentId = int.Parse(line);
            }
			DepartmentId = departmentId;
        }



		public void TeacherLogIn()
		{
            Teacher teacher = new Teacher();
            Console.WriteLine("TEACHER LOG IN MODULE CALLED: ");

            Console.WriteLine("First name: ");
            teacher.FirstName = Console.ReadLine();

			Console.WriteLine("Last name: ");
            teacher.LastName = Console.ReadLine();

            Console.WriteLine("Teacher code: ");
            teacher.TeacherCode = Console.ReadLine();

            Console.WriteLine("Contract number: ");
            string cNumber = Console.ReadLine();

            Console.WriteLine("Signature: ");
            string s = Console.ReadLine();

            contract.SetContractDetails(contract, cNumber, s);

            Console.WriteLine("The contract details for the teacher " + teacher.FirstName + " " + teacher.LastName + " code: " + teacher.TeacherCode + " are: ");
            Console.WriteLine("Contract number: " + contract.ContractNumber + " contract signature: " + contract.Signature);

        }

    }
}

