using System;

namespace SmsApp.Dao.Entity
{
	public class Message
	{
		private long id;
		private string numberReceiver;
		private string messageBody;
		private DateTime sendAt;

		public Message ( long id, string numberReceiver, string messageBody, DateTime sendAt )
		{
		}

		public Message()
		{
		}

		public void setId( long id )
		{
			this.id = id;
		}

		public long getId()
		{	
			return this.id;
		}

		public void setNumberReceiver( string numberReceiver )
		{
			this.numberReceiver = numberReceiver;
		}

		public string getNumberReceiver()
		{
			return this.numberReceiver;
		}

		public void setMessageBody( string messageBody )
		{
			this.messageBody = messageBody;
		}

		public string getMessageBody()
		{
			return this.messageBody;
		}

		public void setSendAt( DateTime sendAt )
		{
			this.sendAt = sendAt;
		}

		public DateTime getSendAt( )
		{
			return this.sendAt;
		}
	}
}

