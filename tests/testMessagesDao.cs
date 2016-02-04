using System;

using SmsApp.Dao;
using SmsApp.Dao.Entity;
using SmsApp.Dao.Repository;

namespace SmsApp.tests
{
	public class testMessagesDao
	{
		MessagesRepository messageRepo = null;

		public testMessagesDao(int testNumber)
		{
			this.messageRepo = DaoFactory.getDao (DaoFactory.MySql).getMessagesRepository ();

			switch( testNumber )
			{
			case 0:

				break;
			}
		}
	}
}

