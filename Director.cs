using System;
namespace LabAI
{
	public class Director
	{
		public Director()
		{
		}

		//private attributes
		private string _password;
		private int mandate;

		//public proprietes
		public string Password {set; get;}

		//public methods
		public string GetHashedPassword(Director director)
		{
            string hashedPassword;
            hashedPassword = "absdidbis" + director.Password + "sdasdasdas";
            return hashedPassword;
        }
	}
}

