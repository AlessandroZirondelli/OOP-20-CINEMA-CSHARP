namespace OOP20_CINEMA_CSHARP.Pagano
{
	public interface IAccount
	{
		/// Returns the account's name. 
		string Name {get;set;}

		/// Returns the account's surname.
		string Surname {get;set;}

		/// Returns the account's username. 
		string Username {get;set;}

		/// Returns the account's password.
		string Password {get;set;}

		/// Returns the account's type. Administrator or operator.
		TypeAccount Type();

	}

}