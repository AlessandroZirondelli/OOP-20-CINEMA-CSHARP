namespace Pagano
{
	public interface IAccountModel
	{
		/// Add new Account. 
		void AddAccount(Account newAccount);

		/// Delete specific Account.
		void RemoveAccount(Account oldAccount);

		/// Recover all account from account's set. 
		Set<Account> Accounts {get;}

		/// Account logged in that time.
		Account AccountLogged {get;set;}
	}

}