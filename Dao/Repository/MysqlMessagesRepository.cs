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
				"`messages`.`sendAt` " +
				"FROM SmsApplicatie.messages " +
				"WHERE id=" + id.ToString;

			MySqlCommand statement = this.databaseConnection.CreateCommand ();
			statement.CommandText = sql;

			MySqlDataReader reader = statement.ExecuteReader ();

			if (reader.Read ()) 
			{
				Message message = new Message ( 
					Convert.ToUInt32( reader["id"] ),
					Convert.ToString( reader["nuberReceiver"] ),
					Convert.ToString( reader["message"] ),
					Convert.ToDateTime( reader["sendAt"] )
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
				"`messages`.`sendAt` " +
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

		public List<Message> getMessagesByUserId (UInt32 userId)
		{
			List<Message> messages = new List<Message> ();

			string sql = "SELECT `messages`.`id`, `messages`.`nuberReceiver`, `messages`.`message`, `messages`.`sendAt` FROM SmsApplicatie.messages WHERE ";
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
	}
}

