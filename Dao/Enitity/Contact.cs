using System;

namespace SmsApp.Dao.Entity
{
	public class Contact
	{
		private long id;
		private string telephoneNumber;
		private string alias;
		private string firstName;
		private string lastName;
		private string emailAddress;

		public Contact ( long id, string telephoneNumber, string alias, string firstName, string lastName, string emailAddress )
		{
			setId (id);
			setTelephoneNumber (telephoneNumber);
			setAlias (alias);
			setFirstName (firstName);
			setLastName (lastName);
			setEmailAddress (emailAddress);
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

		public void setFirstName( string firstName )
		{
			this.firstName = firstName;
		}

		public string getFirstName()
		{
			return this.firstName;
		}

		public void setLastName( string lastName )
		{
			this.lastName = lastName;
		}

		public string getLastName()
		{
			return this.lastName;
		}

		public void setEmailAddress( string emailAddress )
		{
			this.emailAddress = emailAddress;
		}

		public string getEmailAddress()
		{
			return this.emailAddress;
		}
	}
}

