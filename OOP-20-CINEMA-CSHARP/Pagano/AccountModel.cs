using System.Collections.Generic;

namespace OOP20_CINEMA_CSHARP.Pagano
{
	/// Implements Account model. 
	public class AccountModel : IAccountModel
	{
		private readonly ISet<Account> collect;
		private Account accountLogged;

		/// Constructor for the Account Model. 
		public AccountModel(ISet<Account> setAccount)
		{
			this.collect = setAccount;
		}

		public void AddAccount(Account newAccount)
		{
			this.collect.Add(newAccount);
		}

		public void RemoveAccount(Account oldAccount)
		{
			this.collect.Remove(oldAccount);
		}

		public ISet<Account> GetAccounts()
		{
			return this.collect;
		}

		public override string ToString()
		{
			return "Account " + collect;
		}

		public Account AccountLogged
		{
			get
			{
				return this.accountLogged;
			}
			set
			{
				this.accountLogged = value;
			}
		}

	}

}