using System;
using System.Collections.Generic;
using SmsApp.Dao.Entity;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.Common;

namespace SmsApp.Dao.Repository
{
	public class MysqlMessagesRepository : MessagesRepository
	{
		private MySqlConnection databaseConnection = null;

		public MysqlMessagesRepository ( MySqlConnection connection )
		{
			this.databaseConnection = connection;
		}

		public Message getMessageById( UInt32 id )
		{
			string sql = "`SELECT " +
			             "messages`.`id`, " +
			             "`messages`.`nuberReceiver`, " +
			             "`messages`.`message`, " +
			             "`messages`.`sendAt`, " +
			             "`messages`.`contactId` " +
			             "FROM SmsApplicatie.messages " +
			             "WHERE id=:id";

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Parameters.AddWithValue ("id", id.ToString ());

			MySqlDataReader reader = statement.ExecuteReader ();

			if (reader.Read ()) 
			{
				Message message = new Message ( 
					Convert.ToUInt32( reader["id"] ),
					Convert.ToString( reader["nuberReceiver"] ),
					Convert.ToString( reader["message"] ),
					Convert.ToDateTime( reader["sendAt"] ),
					Convert.ToUInt32( reader["contactId"] )
				);
				return new Message ();
			}
			return null;
		}

		public List<Message> getAllMessages( )
		{
			List<Message> messages = new List<Message> ();

			string sql = "SELECT " +
			             "`messages`.`id`, " +
			             "`messages`.`nuberReceiver`, " +
			             "`messages`.`message`, " +
			             "`messages`.`sendAt`, " +
			             "`messages`.`contactId` " +
			             "FROM SmsApplicatie.messages";

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;

			MySqlDataReader reader = statement.ExecuteReader ();

			while (reader.Read ()) 
			{
				Message message = new Message ();
				message.setId ( Convert.ToUInt32( reader ["id"] ));
				message.setNumberReceiver ( Convert.ToString( reader ["nuberReceiver"] ));
				message.setMessageBody ( Convert.ToString(reader ["message"]));
				message.setSendAt ( Convert.ToDateTime( reader ["sendAt"] ));

				messages.Add (message);
			}
			return messages;
		}

		public List<Message> getMessagesByContactId (UInt32 contactId )
		{
			List<Message> messages = new List<Message> ();

			string sql = "SELECT " +
			             "messages`.`id`, " +
			             "`messages`.`nuberReceiver`, " +
			             "`messages`.`message`, " +
			             "`messages`.`sendAt`, " +
			             "`messages`.`contactId` " +
			             "FROM SmsApplicatie.messages " +
			             "WHERE contactId=:contactId";

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Parameters.AddWithValue ("contactId", contactId.ToString());

			MySqlDataReader reader = statement.ExecuteReader ();

			while (reader.Read ()) 
			{
				Message message = new Message ();
				message.setId ( Convert.ToUInt32( reader ["id"] ));
				message.setNumberReceiver ( Convert.ToString( reader ["nuberReceiver"] ));
				message.setMessageBody ( Convert.ToString(reader ["message"]));
				message.setSendAt ( Convert.ToDateTime( reader ["sendAt"] ));
				message.setContactId (Convert.ToUInt32 (reader ["contactId"]));

				messages.Add (message);
			}
			return messages;
		}

		public List<Message> getMessagesByNumberReceiver( string numberReceiver )
		{
			List<Message> messages = new List<Message> ();

			string sql = "SELECT " +
			             "messages`.`id`, " +
			             "`messages`.`nuberReceiver`, " +
			             "`messages`.`message`, " +
			             "`messages`.`sendAt`, " +
			             "`messages`.`contactId` " +
			             "FROM SmsApplicatie.messages " +
			             "WHERE numberReceiver=:numberReceiver";

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Parameters.AddWithValue ("numberReceiver", numberReceiver);

			MySqlDataReader reader = statement.ExecuteReader ();

			while (reader.Read ()) 
			{
				Message message = new Message ();
				message.setId ( Convert.ToUInt32( reader ["id"] ));
				message.setNumberReceiver ( Convert.ToString( reader ["nuberReceiver"] ));
				message.setMessageBody ( Convert.ToString(reader ["message"]));
				message.setSendAt ( Convert.ToDateTime( reader ["sendAt"] ));
				message.setContactId (Convert.ToUInt32 (reader ["contactId"]));

				messages.Add (message);
			}
			return messages;
		}

		public void insertMessege ( Message message)
		{
			string sql = "INSERT INTO `SmsApplicatie`.`messages`( numberReceiver, message, sendAt, contactId ) " +
			             "VALUES ( :numberReceiver, :message, :sendAt, :contactId )";

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Prepare ();
			statement.Parameters.AddWithValue ( "numberReceiver", message.getNumberReceiver() );
			statement.Parameters.AddWithValue ("message", message.getMessageBody () );
			statement.Parameters.AddWithValue ("sendAt", Convert.ToString (message.getSendAt ()));
			statement.Parameters.AddWithValue ("contactId", message.getContactId ());

			if ( statement.ExecuteNonQuery () > 0 ){
				throw new ApplicationException ();
			}
		}

		public void deleteMessage ( Message message)
		{
			string sql = "DELETE FROM `SmsApplicatie`.`messages` WHERE id=:id";
			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Prepare ();
			statement.Parameters.AddWithValue ( "id", message.getId() );

			if ( statement.ExecuteNonQuery () > 0 ) {
				throw new ApplicationException ("Can not delete message with id: " + message.getId());
			}
		}

		public void updateMessage ( Message message)
		{
			string sql = "UPDATE `SmsApplicatie`.`messages` " +
			             "SET numberReceiver=:numberReceiver, message=:message, sendAt=:sendAt, contactId=:contactId" +
			             "where id=:id";
			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;
			statement.Prepare ();
			statement.Parameters.AddWithValue ( "numberReceiver", message.getNumberReceiver() );
			statement.Parameters.AddWithValue ( "message", message.getMessageBody() );
			statement.Parameters.AddWithValue ( "sendAt", message.getSendAt() );
			statement.Parameters.AddWithValue ( "contactId", message.getContactId() );
			statement.Parameters.AddWithValue ( "id", message.getId() );
		}
	}
}

