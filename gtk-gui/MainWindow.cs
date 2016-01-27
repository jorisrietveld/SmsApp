
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action smsAction;
	
	private global::Gtk.Action smsVerstuurenAction;
	
	private global::Gtk.Action smsOverzichtAction;
	
	private global::Gtk.Action contactAction;
	
	private global::Gtk.Action contactToevoegenAction;
	
	private global::Gtk.Action contactVerwijderenAction;
	
	private global::Gtk.Action contactOverzichtAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action OverSmsAppAction;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.MenuBar menubar3;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView LogTextView;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.smsAction = new global::Gtk.Action ("smsAction", global::Mono.Unix.Catalog.GetString ("sms"), null, null);
		this.smsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("sms");
		w1.Add (this.smsAction, null);
		this.smsVerstuurenAction = new global::Gtk.Action ("smsVerstuurenAction", global::Mono.Unix.Catalog.GetString ("sms verstuuren"), null, null);
		this.smsVerstuurenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("sms verstuuren");
		w1.Add (this.smsVerstuurenAction, null);
		this.smsOverzichtAction = new global::Gtk.Action ("smsOverzichtAction", global::Mono.Unix.Catalog.GetString ("sms overzicht"), null, null);
		this.smsOverzichtAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("sms overzicht");
		w1.Add (this.smsOverzichtAction, null);
		this.contactAction = new global::Gtk.Action ("contactAction", global::Mono.Unix.Catalog.GetString ("contact"), null, null);
		this.contactAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("contact");
		w1.Add (this.contactAction, null);
		this.contactToevoegenAction = new global::Gtk.Action ("contactToevoegenAction", global::Mono.Unix.Catalog.GetString ("contact toevoegen"), null, null);
		this.contactToevoegenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("contact toevoegen");
		w1.Add (this.contactToevoegenAction, null);
		this.contactVerwijderenAction = new global::Gtk.Action ("contactVerwijderenAction", global::Mono.Unix.Catalog.GetString ("contact verwijderen"), null, null);
		this.contactVerwijderenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("contact verwijderen");
		w1.Add (this.contactVerwijderenAction, null);
		this.contactOverzichtAction = new global::Gtk.Action ("contactOverzichtAction", global::Mono.Unix.Catalog.GetString ("contact overzicht"), null, null);
		this.contactOverzichtAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("contact overzicht");
		w1.Add (this.contactOverzichtAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.OverSmsAppAction = new global::Gtk.Action ("OverSmsAppAction", global::Mono.Unix.Catalog.GetString ("Over SmsApp"), null, null);
		this.OverSmsAppAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Over SmsApp");
		w1.Add (this.OverSmsAppAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Sms App");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar3'><menu name='smsAction' action='smsAction'><menuitem name='smsVerstuurenAction' action='smsVerstuurenAction'/><menuitem name='smsOverzichtAction' action='smsOverzichtAction'/></menu><menu name='contactAction' action='contactAction'><menuitem name='contactToevoegenAction' action='contactToevoegenAction'/><menuitem name='contactVerwijderenAction' action='contactVerwijderenAction'/><menuitem name='contactOverzichtAction' action='contactOverzichtAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='OverSmsAppAction' action='OverSmsAppAction'/></menu></menubar></ui>");
		this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar3")));
		this.menubar3.Name = "menubar3";
		this.vbox2.Add (this.menubar3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.LogTextView = new global::Gtk.TextView ();
		this.LogTextView.CanFocus = true;
		this.LogTextView.Name = "LogTextView";
		this.GtkScrolledWindow.Add (this.LogTextView);
		this.vbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
		w4.Position = 1;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 450;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.smsVerstuurenAction.Activated += new global::System.EventHandler (this.OpenSendMessageWindow);
		this.smsOverzichtAction.Activated += new global::System.EventHandler (this.OpenSmsOverviewWindow);
		this.contactToevoegenAction.Activated += new global::System.EventHandler (this.OpenAddContactWindow);
		this.contactVerwijderenAction.Activated += new global::System.EventHandler (this.OpenRemoveContactWindow);
		this.contactOverzichtAction.Activated += new global::System.EventHandler (this.OpenContactOverviewWindow);
		this.OverSmsAppAction.Activated += new global::System.EventHandler (this.OpenAboutWindow);
	}
}