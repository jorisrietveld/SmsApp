using System;
using SmsApp.Dao.Entity;
using System.Collections.Generic;

namespace SmsApp.Dao.Repository
{
	public interface MessagesRepository
	{
		Message getMessageById( long id );

		List<Message> getAllMessages( );

		List<Message> getMessagesByUserId (long userId);

	}
}

