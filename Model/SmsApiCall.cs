using System;
using SmsApp.Dao.Entity;

namespace SmsApp.Model
{
	public interface SmsApiCall
	{
		void sendMessage (Message message);
	}
}

