using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using SmsApp.Dao.Entity;

namespace SmsApp.Dao
{
	public abstract class DaoFactory
	{
		public static readonly int MySql = 1;
		public static readonly int SQLite = 2;

		public DaoFactory ()
		{
		}

		public DaoFactory getDao( int witchDao )
		{
			switch (witchDao) {

			case 1:
				return new MysqlDaoFactory ();
				break;

			default:
				return null;
				break;
			
			}
		}
	}
}

