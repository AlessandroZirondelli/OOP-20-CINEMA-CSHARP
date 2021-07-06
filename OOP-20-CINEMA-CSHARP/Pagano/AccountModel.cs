namespace Pagano
{
	/// Implements Account model. 
	public class AccountModel : IAccountModel
	{
		private readonly Set<Account> collect;
		private Account accountLogged;

		/// Constructor for the Account Model. 
		public AccountModelImpl(Set<Account> setAccount)
		{
			this.collect = setAccount;
		}

		public override void AddAccount(Account newAccount)
		{
			this.collect.Add(newAccount);
		}

		public override void RemoveAccount(Account oldAccount)
		{
			this.collect.remove(oldAccount);
		}

		public override Set<Account> Accounts
		{
			get
			{
				return this.collect;
			}
		}

		public override string ToString()
		{
			return "Account " + collect;
		}

		public override Account AccountLogged
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