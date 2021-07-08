using OOP20_CINEMA_CSHARP.Pagano;
using System.Collections.Generic;
using Xunit;

namespace OOP20_CINEMA_CSHARP.Test
{
	public class TestLogin
	{
		[Fact]
		public virtual void testLogin()
		{
			ISet<Account> setAccount = new HashSet<Account>();
			IAccount a1 = new Account("Mario", "Rossi", "Ross", "qwerty", TypeAccount.OPERATOR);
			IAccount a2 = new Account("Giacomo", "Pippo", "Giac", "qwerty1", TypeAccount.ADMINISTRATOR);
			IAccount a3 = new Account("Piero", "Suli", "Pier", "qwerty123", TypeAccount.OPERATOR);

			setAccount.Add((Account)a1);
			setAccount.Add((Account)a2);
			setAccount.Add((Account)a3);

			IAccountModel modelAccount = new AccountModel(setAccount);
			modelAccount.AccountLogged = (Account)a2;
			
			Assert.Equal(modelAccount.AccountLogged, a2);
		}
	}

}