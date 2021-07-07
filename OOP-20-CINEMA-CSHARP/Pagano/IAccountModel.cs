using System.Collections.Generic;

namespace OOP20_CINEMA_CSHARP.Pagano
{
	public interface IAccountModel
	{
		/// Add new Account. 
		void AddAccount(Account newAccount);

		/// Delete specific Account.
		void RemoveAccount(Account oldAccount);

		/// Recover all account from account's set. 
		ISet<Account> GetAccounts();

		/// Account logged in that time.
		Account AccountLogged {get;set;}
	}

}