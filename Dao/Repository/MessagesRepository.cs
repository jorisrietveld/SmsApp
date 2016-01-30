using System;
using SmsApp.Dao.Entity;
using System.Collections.Generic;

namespace SmsApp.Dao.Repository
{
	public interface MessagesRepository
	{
		Message getMessageById( UInt32 id );
		List<Message> getAllMessages( );
		List<Message> getMessagesByContactId ( UInt32 userId);
		List<Message> getMessagesByNumberReceiver( string numberReceiver );
	}
}

