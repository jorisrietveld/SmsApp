using System;
using Gtk;
using SmsApp;
using SmsApp.Dao;
using SmsApp.Controller;

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
		SendSmsWindow window = new SendSmsWindow ();
		window.Show ();
		//LogTextView.Buffer.Text = "Stuur een nieuw sms bericht";
	}
	/**
	 * This is the handler for the MainMenu->sms->SmsOverview button.
	 */
	protected void OpenSmsOverviewWindow (object sender, EventArgs e)
	{
		try{
			MessageController controller = new MessageController ();
			LogTextView.Buffer.Text = controller.testQuery ();
		}
		catch( Exception exception ) 
		{
			this.showErrorDialog ( exception );
		}
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

	protected void showErrorDialog( MessageType typeOfMessage, ButtonsType typeOfButtons, string errorMessage )
	{
		MessageDialog errorDialog = new MessageDialog ( null, DialogFlags.Modal, typeOfMessage, typeOfButtons, errorMessage);
		errorDialog.Run ();
		errorDialog.Destroy ();
	}
	protected void showErrorDialog( string errorMessage )
	{
		MessageDialog errorDialog = new MessageDialog( this, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, errorMessage);
		errorDialog.Run ();
		errorDialog.Destroy ();
	}
	protected void showErrorDialog( Exception exception )
	{
		string errorMessage = "An exception has been thrown!\n" +
		                      "[Message]\n " + exception.Message + "\n" +
			"[Strack trace] \n" + exception.StackTrace;

		MessageDialog errorDialog = new MessageDialog( this, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, false, errorMessage);
		errorDialog.Run ();
		errorDialog.Destroy ();
	}
}
