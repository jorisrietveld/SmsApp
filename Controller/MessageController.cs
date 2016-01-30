using System;
using System.Collections.Generic;

using SmsApp.Dao;
using SmsApp.Dao.Repository;
using SmsApp.Dao.Entity;

namespace SmsApp.Controller
{
	public class MessageController
	{
		public MessageController ()
		{
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
	}
}

