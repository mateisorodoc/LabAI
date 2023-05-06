using System;
namespace LabAI
{
	public class Staff : Employee
	{
		public Staff()
		{
		}


		//protected attributes
		protected int _accessLevel;

		//public proprietes
		public int AccessLevel { set; get; }

		//public attributes
		string position;

        //public methods
        public void StaffLogIn()
		{
  
            Console.WriteLine("STAFF LOG IN MODULE CALLED: ");
            Console.WriteLine("Access level: ");

            string line;

            line = Console.ReadLine();
            int al = int.Parse(line);

            var staff = new Staff();

            staff._accessLevel = al;

            Console.WriteLine("CNP: ");
            staff._cnp = Console.ReadLine() ;

            if (staff._accessLevel <= 3)
            {
                Console.WriteLine("First name: ");
                line = Console.ReadLine();
                staff.FirstName = line;

                Console.WriteLine("Last name: ");
                line = Console.ReadLine();
                staff.LastName = line;

                Console.WriteLine("Contract number: ");
                string cNumber = Console.ReadLine();

                Console.WriteLine("Signature: ");
                string s = Console.ReadLine();
                
                contract.SetContractDetails(contract, cNumber, s);

                Console.WriteLine("For staff member " + staff.FirstName + " " + staff.LastName + " with access level " + staff._accessLevel + " you entered the contract number " + contract.ContractNumber );
                 
            }
            else if (staff._accessLevel == 10)
            {
                Console.WriteLine("Hello, director");

            }
            else if (staff._accessLevel > 3 && staff._accessLevel < 10)
            {
                Console.WriteLine("First name: ");
                line = Console.ReadLine();
                staff.FirstName = line;

                Console.WriteLine("Last name: ");
                line = Console.ReadLine();
                staff.LastName = line;

                Console.WriteLine("Department ID: ");
                line = Console.ReadLine();
                staff.DepartmentId = int.Parse(line);


                Console.WriteLine("Work email: ");
                line = Console.ReadLine();
                staff.workEmail = line;


                Console.WriteLine("Contract number: ");
                string cNumber = Console.ReadLine();

                Console.WriteLine("Signature: ");
                string s = Console.ReadLine();

                contract.SetContractDetails(contract, cNumber, s);
                Console.WriteLine("For staff member " + staff.FirstName + " " + staff.LastName + " with access level " + staff._accessLevel + " you entered the contract number " + contract.ContractNumber);
            }


        }
        public void StaticBinding()
        {
            Console.WriteLine("Staff::StaticBinding");
        }

        public override void DynamicBinding ()
        {
            Console.WriteLine("Staff::DynamicBinding");
        }
    }
}

