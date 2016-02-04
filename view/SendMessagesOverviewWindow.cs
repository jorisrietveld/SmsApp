using System;

namespace SmsApp.view
{
	public class SendMessagesOverviewWindow
	{
		public SendMessagesOverviewWindow()
		{
			// Create window
			Gtk.Window window = new Gtk.Window ( "Verzonden Berichten" );
			window.SetSizeRequest (700, 200);

			// Add tree to window
			Gtk.TreeView tree = new Gtk.TreeView ();
			window.Add (tree);

			// Create the text cell that will display the telephone number
			Gtk.TreeViewColumn numberReceiverColumn = new Gtk.TreeViewColumn ();
			numberReceiverColumn.Title = "Telefoon nummer";
			numberReceiverColumn.MinWidth = 200;

			Gtk.CellRendererText numberReceiverCell = new Gtk.CellRendererText ();
			numberReceiverColumn.PackStart (numberReceiverCell, true);

			Gtk.TreeViewColumn messageColumn = new Gtk.TreeViewColumn ();
			messageColumn.Title = "Bericht";
			messageColumn.MinWidth = 300;

			Gtk.CellRendererText messageCell = new Gtk.CellRendererText ();
			messageColumn.PackStart (messageCell, true);

			Gtk.TreeViewColumn sendAtColumn = new Gtk.TreeViewColumn ();
			sendAtColumn.Title = "Verstuurd op";
			sendAtColumn.MinWidth = 200;

			Gtk.CellRendererText sendAtCell = new Gtk.CellRendererText ();
			sendAtColumn.PackStart (sendAtCell, true);

			tree.AppendColumn (numberReceiverColumn);
			tree.AppendColumn (messageColumn);
			tree.AppendColumn (sendAtColumn);

			numberReceiverColumn.AddAttribute (numberReceiverCell, "text", 0);
			messageColumn.AddAttribute (numberReceiverCell, "text", 1);
			sendAtColumn.AddAttribute (sendAtCell, "text", 2);

			Gtk.ListStore messageListStore = new Gtk.ListStore ( typeof(string), typeof(string), typeof(string) );

			messageListStore.AppendValues ( "0615118905", "this is an test message", "vandaag") ;
			tree.Model = messageListStore;

			window.ShowAll ();
		}
	}
}

