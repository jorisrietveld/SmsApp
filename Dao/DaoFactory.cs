using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using SmsApp.Dao.Entity;
using SmsApp.Dao.Repository;

namespace SmsApp.Dao
{
	public abstract class DaoFactory
	{
		public static readonly int MySql = 1;
		public static readonly int SQLite = 2;

		public abstract MessagesRepository getMessagesRepository();

		public static DaoFactory getDao( int witchDao )
		{
			switch (witchDao) {

			case 1:
				return new MysqlDaoFactory ();

			default:
				return null;
			
			}
		}
	}
}

