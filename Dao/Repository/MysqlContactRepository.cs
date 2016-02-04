using System;
using SmsApp.Dao.Entity;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.Common;

namespace SmsApp.Dao.Repository
{
	public class MysqlContactRepository : ContactRepository
	{
		private MySqlConnection databaseConnection = null;

		public MysqlContactRepository ( MySqlConnection connection )
		{
			this.databaseConnection = connection;
		}

		public Contact getContactById( UInt32 id )
		{
			string sql = "SELECT " +
			             "`contacts`.`id`, " +
			             "`contacts`.`telephoneNumber`, " +
			             "`contacts`.`alias`, " +
			             "`contacts`.`firstName`, " +
			             "`contacts`.`lastName`, " +
			             "`contacts`.`emailAddress` " +
			             "FROM `SmsApplicatie`.`contacts` WHERE id=:id ";
			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Parameters.AddWithValue ("id", id);
			MySqlDataReader reader = statement.ExecuteReader ();

			if (reader.Read ()) 
			{
				Contact contact = new Contact (
					                  Convert.ToUInt32 (reader ["id"]),
					                  Convert.ToString (reader ["telephoneNumber"]),
					                  Convert.ToString (reader ["alias"]),
					                  Convert.ToString (reader ["firstName"]),
					                  Convert.ToString (reader ["lastName"]),
					                  Convert.ToString (reader ["emailAddress"])
				                  );
				return contact;
			} 
			else 
			{
				return null;
			}

		}

		public List<Contact> getAllContacts( )
		{
			string whereClause = "";
			Dictionary<string, string> boundValues = new Dictionary<string, string>();

			List<Contact> contacts = this.getContacts (whereClause, boundValues);
			return contacts;
		}

		public List<Contact> getContactsByTelephoneNumber( string telephoneNumber )
		{
			string whereClause = "WHERE telephoneNumber LIKE :telephoneNumber%";
			Dictionary<string, string> boundValues = new Dictionary<string, string>();
			boundValues.Add ("telephoneNumber", telephoneNumber);
			List<Contact> contacts = this.getContacts (whereClause, boundValues);
			return contacts;
		}

		public List<Contact> getContactsByFirstName (string firstName)
		{
			string whereClause = "WHERE firstName LIKE :firstName%";
			Dictionary<string, string> boundValues = new Dictionary<string, string>();

			List<Contact> contacts = this.getContacts (whereClause, boundValues);
			return contacts;
		}

		public List<Contact> getContactsByLastName (string lastName)
		{
			string whereClause = "WHERE firstName LIKE :firstName%";
			Dictionary<string, string> boundValues = new Dictionary<string, string>();

			List<Contact> contacts = this.getContacts (whereClause, boundValues);
			return contacts;
		}

		public List<Contact> getContactsByEmail (string email)
		{
			string whereClause = "WHERE firstName LIKE :firstName%";
			Dictionary<string, string> boundValues = new Dictionary<string, string>();

			List<Contact> contacts = this.getContacts (whereClause, boundValues);
			return contacts;
		}

		private List<Contact> getContacts( string whereClause, Dictionary<string, string> boundValues)
		{ 
			List<Contact> contacts = new List<Contact> ();

			string sql = "SELECT " +
			             "`contacts`.`id`, " +
			             "`contacts`.`telephoneNumber`, " +
			             "`contacts`.`alias`, " +
			             "`contacts`.`firstName`, " +
			             "`contacts`.`lastName`, " +
			             "`contacts`.`emailAddress` " +
			             "FROM `SmsApplicatie`.`contacts` " + whereClause;

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;

			foreach (var item in boundValues) 
			{
				statement.Parameters.AddWithValue ( item.Key , item.Value );
			}

			MySqlDataReader reader = statement.ExecuteReader ();

			while (reader.Read ()) 
			{
				Contact contact = new Contact ();
				contact.setId ( Convert.ToUInt32( reader["id"] ));
				contact.setTelephoneNumber ( Convert.ToString( reader["telephoneNumber"] ));
				contact.setAlias ( Convert.ToString( reader["alias"]) );
				contact.setFirstName ( Convert.ToString( reader["firstName"]) );
				contact.setLastName ( Convert.ToString( reader["lastName"] ) );
				contact.setEmailAddress ( Convert.ToString( reader["emailAddress"] ) );
				contacts.Add (contact);
			}

			return contacts;
		}

		public void insertContact ( Contact contact)
		{
			string sql = "INSERT INTO `SmsApplicatie`.`contacts`(telephoneNumber, alias, firstName, lastName, emailAddress ) " +
				"VALUES :telephoneNumber, :alias, :firstName, :lastName, :emailAddress";

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Prepare ();
			statement.Parameters.AddWithValue ("telephoneNumber", contact.getTelephoneNumber ());
			statement.Parameters.AddWithValue ("alias", contact.getAlias ());
			statement.Parameters.AddWithValue ("firstName", contact.getFirstName ());
			statement.Parameters.AddWithValue ("lastName", contact.getLastName ());
			statement.Parameters.AddWithValue ("emailAddress", contact.getEmailAddress ());

			if ( statement.ExecuteNonQuery () == 0 ){
				throw new ApplicationException ();
			}
		}

		public void deleteContact ( Contact message)
		{
			string sql = "DELETE FROM `SmsApplicatie`.`contacts` WHERE id=:id";
			MySqlCommand statement = databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Prepare ();
			statement.Parameters.AddWithValue ("id", message.getId());

			if ( statement.ExecuteNonQuery () == 0 ){
				throw new ApplicationException ();
			}
		}

		public void updateContact ( Contact contact)
		{
			string sql = "UPDATE `SmsApplicatie`.`contact` " +
			             "SET" +
			             "telephoneNumber=:telephoneNumber," +
			             "alias=:alias," +
			             "firstName=:firstName," +
			             "lastName=:lastName," +
			             "emailAddress=:emailAddress WHERE id=:id";
			MySqlCommand statement = databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Prepare ();
			statement.Parameters.AddWithValue( "telephoneNumber", contact.getTelephoneNumber());
			statement.Parameters.AddWithValue ( "alias", contact.getAlias());
			statement.Parameters.AddWithValue ( "firstName", contact.getFirstName() );
			statement.Parameters.AddWithValue ( "lastName", contact.getLastName() );
			statement.Parameters.AddWithValue ( "emailAddress", contact.getEmailAddress() );

			if ( statement.ExecuteNonQuery () == 0 ){
				throw new ApplicationException ();
			}

		}
	}
}

