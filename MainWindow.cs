using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	/**
	 * This is to handle the close button
	 */
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	/**
	 * This is the handler for the MainMenu->Sms->SendSms button.
	 */
	protected void OpenSendMessageWindow (object sender, EventArgs e)
	{
		LogTextView.Buffer.Text = "Stuur een nieuw sms bericht";
	}

	/**
	 * This is the handler for the MainMenu->sms->SmsOverview button.
	 */
	protected void OpenSmsOverviewWindow (object sender, EventArgs e)
	{
		LogTextView.Buffer.Text = "Verzonden sms berichten";
	}

	/**
	 * This is the handler for the MainMenu>Contact>AddContact button.
	 */
	protected void OpenAddContactWindow (object sender, EventArgs e)
	{
		LogTextView.Buffer.Text = "Een contact toevoegen";
	}

	/**
	 * This is the handler for the MainMenu>Contact>RemoveContact button.
	 */
	protected void OpenRemoveContactWindow (object sender, EventArgs e)
	{
		LogTextView.Buffer.Text = "Een contact verwijderen";
	}

	/**
	 * This is the handler for the MainMenu>Contact>ContactOverview button.
	 */
	protected void OpenContactOverviewWindow (object sender, EventArgs e)
	{
		LogTextView.Buffer.Text = "Contact overzicht";
	}

	/**
	 * This is the handler for opening the MainMenu>Help>About button.
	 */
	protected void OpenAboutWindow (object sender, EventArgs e)
	{
		AboutDialog about = new AboutDialog ();
		about.ProgramName = "SMS Appliction";
		about.Version = " Version: 0.1";
		about.Run ();
		about.Destroy ();
	}
}
