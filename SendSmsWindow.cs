using System;

namespace SmsApp
{
	public partial class SendSmsWindow : Gtk.Window
	{
		public SendSmsWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

