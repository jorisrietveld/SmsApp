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
			ViaNetApiCall viaNetApiModel = new ViaNetApiCall ();
			ViaNetApiCall.Result callResult;
			callResult = viaNetApiModel.sendSMS ( message );

			if (callResult.Success) {
				// Message is send successfully
				this.messageRepo.insertMessege ( message );
			} else {
				throw new ApplicationException ("[Code] " + callResult.ErrorCode + " [Message] " + callResult.ErrorMessage);
			}
		}


	}
}

