using System;

namespace Pagano
{

	public class Account : IAccount
	{
		private string name;
		private string surname;
		private string username;
		private string pass;
		private TypeAccount type;

		/// Constructor for the class Account.
		public AccountImpl(string name, string surname, string username, string pass, TypeAccount type)
		{
			this.name = name; //Unique name
			this.surname = surname;
			this.username = username;
			this.pass = pass;
			this.type = type;
		}

		/// name of the account.
		public string Name
        {
			get
			{
				return name;
			}
			set
			{
				this.name = value;
			}
        }

		///surname of the account.
		public string Surname
		{
			get
			{
				return surname;
			}
			set
			{
				this.surname = value;
			}
		}

		/// username of the account.
		public string Username
		{
			get
			{
				return username;
			}
			set
			{
				this.username = value;
			}
		}

		/// password of the account.
		public string Password
		{
			get
			{
				return pass;
			}
			set
			{
				if (!value.Equals(this.pass))
				{
					this.pass = value;
				}
			}
		}

		/// type of the account. Administrator or operator.
		public TypeAccount type()
		{
			return this.type;
		}

		public override string ToString()
		{
			return "Account :" + " Name: " + name + ", Surname: " + surname + ", Username: " + username + ", Type: " + type;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(name, surname, username, pass, type);
		}

	}
}