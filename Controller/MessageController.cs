using System;
using System.Collections.Generic;

using SmsApp.Dao;
using SmsApp.Dao.Repository;
using SmsApp.Dao.Entity;

namespace SmsApp.Controller
{
	public class MessageController
	{
		private MessagesRepository messageRepo = null;

		public MessageController()
		{
			this.messageRepo = DaoFactory.getDao( DaoFactory.MySql ).getMessagesRepository();
		}

		public List<Message> getAllSendMessages()
		{
			return messageRepo.getAllMessages ();
		}
			
	}
}

