using System;
using System.Collections.Generic;

using SmsApp.Dao;
using SmsApp.Dao.Repository;
using SmsApp.Dao.Entity;
using SmsApp.Model;

namespace SmsApp.Controller
{
	public class MessageController
	{
		private MessagesRepository messageRepo = null;

		public MessageController()
		{
			this.messageRepo = DaoFactory.getDao( DaoFactory.MySql ).getMessagesRepository();
		}

		public void sendMessage( Message message )
		{
			this.messageRepo.insertMessege (message);

		}
	}
}

