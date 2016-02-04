using System;
using SmsApp.Dao;
using SmsApp.Dao.Entity;
using SmsApp.Dao.Repository;
using System.Collections.Generic;

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

			// Create the column for displaying the telephone number.
			Gtk.TreeViewColumn numberReceiverColumn = new Gtk.TreeViewColumn ();
			numberReceiverColumn.Title = "Telefoon nummer";
			numberReceiverColumn.MinWidth = 200;
			// Create the text cell that will display the telephone number.
			Gtk.CellRendererText numberReceiverCell = new Gtk.CellRendererText ();
			// Add the cell to the column.
			numberReceiverColumn.PackStart (numberReceiverCell, true);

			// Create the column for displaing the message.
			Gtk.TreeViewColumn messageColumn = new Gtk.TreeViewColumn ();
			messageColumn.Title = "Bericht";
			messageColumn.MinWidth = 300;
			// Create the text cell that will display the message.
			Gtk.CellRendererText messageCell = new Gtk.CellRendererText ();
			messageColumn.PackStart (messageCell, true);

			// Create the column for displaying the date send.
			Gtk.TreeViewColumn sendAtColumn = new Gtk.TreeViewColumn ();
			sendAtColumn.Title = "Verstuurd op";
			sendAtColumn.MinWidth = 200;
			// Create the text cell that will display the date send.
			Gtk.CellRendererText sendAtCell = new Gtk.CellRendererText ();
			sendAtColumn.PackStart (sendAtCell, true);

			tree.AppendColumn (numberReceiverColumn);
			tree.AppendColumn (messageColumn);
			tree.AppendColumn (sendAtColumn);

			// Tell the cell renderers which items in the model to display
			numberReceiverColumn.AddAttribute (numberReceiverCell, "text", 0);
			messageColumn.AddAttribute (messageCell, "text", 1);
			sendAtColumn.AddAttribute (sendAtCell, "text", 2);

			// Assign the model to the TreeView
			tree.Model = this.getMessageList ();
			// Show the window and everythin on it.
			window.ShowAll ();
		}

		public Gtk.ListStore getMessageList()
		{
			MessagesRepository messageRepo = DaoFactory.getDao (DaoFactory.MySql).getMessagesRepository ();
			List<Message> messages = messageRepo.getAllMessages ();
			Gtk.ListStore messageList = new Gtk.ListStore ( typeof(string), typeof(string), typeof(string) );

			foreach (Message message in messages) 
			{
				messageList.AppendValues (message.getNumberReceiver (), message.getMessageBody (), Convert.ToString (message.getSendAt ()));
			}
			return messageList;
		}
	}
}

