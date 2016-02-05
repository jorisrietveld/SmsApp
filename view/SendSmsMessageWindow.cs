using System;

namespace SmsApp
{
	public partial class SendSmsMessageWindow : Gtk.Window
	{
		public SendSmsMessageWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

