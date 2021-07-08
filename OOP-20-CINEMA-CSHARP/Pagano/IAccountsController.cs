using System.Collections.Generic;

namespace OOP20_CINEMA_CSHARP.Pagano
{
	public interface IAccountsController
	{
		/// Add new Account.
		void AddAccount(Account newAccount);

		/// Delete specific Account.
		void DeleteAccount(Account oldAccount);

		/// Recover all account from account's set. 
		ISet<Account> Accounts {get;}
				
		/// Set Account logged in that time.
		Account AccountLogged {set;get;}

	}

}