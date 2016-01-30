using System;

namespace SmsApp.Dao.Entity
{
	public class Contact
	{
		private long id;
		private string telephoneNumber;
		private string alias;

		public Contact ( long id, string telephoneNumber, string alias )
		{
			setId (id);
			setTelephoneNumber (telephoneNumber);
			setAlias (alias);
		}

		public Contact( )
		{
		}

		public long getId()
		{
			return this.id;
		}

		public void setId( long id )
		{
			this.id = id;
		}

		public void setTelephoneNumber( string telephoneNumber )
		{
			this.telephoneNumber = telephoneNumber;
		}

		public string getTelephoneNumber()
		{
			return this.telephoneNumber;
		}

		public void setAlias( string alias )
		{
			this.alias = alias;
		}

		public string getAlias()
		{
			return this.alias;
		}
	}
}

