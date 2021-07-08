using System.Collections.Generic;
using Xunit;
using OOP20_CINEMA_CSHARP.Pagano;

namespace OOP20_CINEMA_CSHARP.Test
{
	public class TestManageAccounts
	{
		[Fact]
		public void TestDeleteAccounts()
		{
			ISet<Account> setAccount = new HashSet<Account>();
			IAccount a1 = new Account("Mario", "Rossi", "Ross", "qwerty", TypeAccount.OPERATOR);
			IAccount a2 = new Account("Giacomo", "Pippo", "Giac", "qwerty1", TypeAccount.ADMINISTRATOR);
			IAccount a3 = new Account("Piero", "Suli", "Pier", "qwerty123", TypeAccount.OPERATOR);

			setAccount.Add((Account)a1);
			setAccount.Add((Account)a2);
			setAccount.Add((Account)a3);

			IAccountModel model = new AccountModel(setAccount);
			model.RemoveAccount((Account)a3);
			
			setAccount.Remove((Account)a3);
			Assert.Equal(model.GetAccounts(), setAccount);
			
		}

    [Fact]
		void TestAddAccounts()
		{
			ISet<Account> setAccount = new HashSet<Account>();
			IAccount a1 = new Account("Mario", "Rossi", "Ross", "qwerty", TypeAccount.OPERATOR);
			IAccount a2 = new Account("Giacomo", "Pippo", "Giac", "qwerty1", TypeAccount.ADMINISTRATOR);
			IAccount a3 = new Account("Piero", "Suli", "Pier", "qwerty123", TypeAccount.OPERATOR);

			setAccount.Add((Account)a1);
			setAccount.Add((Account)a2);
			setAccount.Add((Account)a3);

			IAccountModel model = new AccountModel(setAccount);
			IAccount a4 = new Account("Luigi", "Costa", "Lu", "luna21", TypeAccount.ADMINISTRATOR);
			model.AddAccount((Account)a4);

			Assert.Equal(model.GetAccounts(), setAccount);
		}

        [Fact]
		void testDeleteLastAdminAccount()
		{
			ISet<Account> setAccount = new HashSet<Account>();
			IAccount a1 = new Account("Mario", "Rossi", "Ross", "qwerty", TypeAccount.ADMINISTRATOR);
			IAccount a2 = new Account("Giacomo", "Pippo", "Giac", "qwerty1", TypeAccount.OPERATOR);

			setAccount.Add((Account)a1);
			setAccount.Add((Account)a2);
			
			IAccountModel model = new AccountModel(setAccount);
			model.RemoveAccount((Account)a1);
			
			
			Assert.Equal(model.GetAccounts(), setAccount);
		}
	}

}