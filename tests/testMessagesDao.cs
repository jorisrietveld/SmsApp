using System;

using SmsApp.Dao;
using SmsApp.Dao.Entity;
using SmsApp.Dao.Repository;

namespace SmsApp.tests
{
	public class testMessagesDao
	{
		private MessagesRepository messageRepo = null;

		public testMessagesDao ()
		{
			this.messageRepo =  new 
		}

		public void saveMessage( string numberReceiver, string message )
		{
			DaoFactory factory = DaoFactory.getDao ( DaoFactory.MySql );
		}

		public string testQuery()
		{
			MessagesRepository repo = DaoFactory.getDao (DaoFactory.MySql).getMessagesRepository ();
			List<Message> messageList = repo.getAllMessages ();
			Message message = messageList [0];
			return message.toString();
		}

		public string testMessageRepository
	}
}

