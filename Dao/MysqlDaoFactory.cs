using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using SmsApp.Dao.Repository;
using System.Data.Common;

namespace SmsApp.Dao
{
	public class MysqlDaoFactory : DaoFactory
	{
		private string connectString = "Server=127.0.0.1; Database=SmsApplicatie; User ID=root; Password=toor; Pooling=false";
		private MySqlConnection databaseConnection = null;

		public MysqlDaoFactory ()
		{
			this.databaseConnection = new MySqlConnection (this.connectString);
			openDatabaseConnection ();
		}

		private void openDatabaseConnection()
		{
			this.databaseConnection.Open ();

		}

		public MySqlConnection getDatabaseConnection()
		{
			if (this.databaseConnection == null) {
				this.openDatabaseConnection ();
			}
			return this.databaseConnection;
		}

		private void closeDatabaseConnection( DbConnection connection )
		{
			connection.Close ();
		}

		public override MessagesRepository getMessagesRepository()
		{
			return new MysqlMessagesRepository (this.databaseConnection);
		}

		~MysqlDaoFactory()
		{
			this.closeDatabaseConnection (this.databaseConnection);
		}
	}
}

