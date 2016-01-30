using System;

namespace SmsApp.Dao.Entity
{
	public class Message
	{
		private UInt32 id;
		private string numberReceiver;
		private string messageBody;
		private DateTime sendAt;

		public Message ( UInt32 id, string numberReceiver, string messageBody, DateTime sendAt )
		{
			this.setId (id);
			this.setNumberReceiver (numberReceiver);
			this.setMessageBody (messageBody);
			this.setSendAt (sendAt);
		}

		public Message()
		{
		}

		public void setId( UInt32 id )
		{
			this.id = id;
		}

		public UInt32 getId()
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

		public string toString()
		{
			string str = "Message{ id:" + this.id + ", " +
				"numberReceiver:" + this.numberReceiver + ", " +
				"messageBody: " + this.messageBody + ", " +
				"sendAt: " + this.sendAt + " } ";
			return str;
		}
	}
}

