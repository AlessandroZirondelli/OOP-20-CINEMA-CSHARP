using System;

namespace OOP20_CINEMA_CSHARP.Pagano
{

	public class Account : IAccount
	{
		private string name;
		private string surname;
		private string username;
		private string pass;
		private TypeAccount type;

		/// Constructor for the class Account.
		public Account(string name, string surname, string username, string pass, TypeAccount type)
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
		public TypeAccount Type()
		{
			return this.type;
		}

		public override string ToString()
		{
			return "" + this.name + " " + this.surname + " " + this.username;
		}

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   name == account.name &&
                   surname == account.surname &&
                   username == account.username &&
                   pass == account.pass &&
                   this.type == account.type &&
                   Name == account.Name &&
                   Surname == account.Surname &&
                   Username == account.Username &&
                   Password == account.Password;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(name);
            hash.Add(surname);
            hash.Add(username);
            hash.Add(pass);
            hash.Add(this.type);
            hash.Add(Name);
            hash.Add(Surname);
            hash.Add(Username);
            hash.Add(Password);
            return hash.ToHashCode();
        }
    }
}