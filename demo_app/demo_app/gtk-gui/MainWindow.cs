
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button btnClickMe;

	private global::Gtk.Label lblMainText;

	private global::Gtk.Label lblMainText1;

	private global::Gtk.Label lblMainText2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnClickMe = new global::Gtk.Button();
		this.btnClickMe.CanFocus = true;
		this.btnClickMe.Name = "btnClickMe";
		this.btnClickMe.UseUnderline = true;
		this.btnClickMe.Label = global::Mono.Unix.Catalog.GetString("Click Me");
		this.fixed1.Add(this.btnClickMe);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnClickMe]));
		w1.X = 243;
		w1.Y = 75;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblMainText = new global::Gtk.Label();
		this.lblMainText.Name = "lblMainText";
		this.fixed1.Add(this.lblMainText);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblMainText]));
		w2.X = 202;
		w2.Y = 200;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblMainText1 = new global::Gtk.Label();
		this.lblMainText1.Name = "lblMainText1";
		this.fixed1.Add(this.lblMainText1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblMainText1]));
		w3.X = 231;
		w3.Y = 124;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblMainText2 = new global::Gtk.Label();
		this.lblMainText2.Name = "lblMainText2";
		this.fixed1.Add(this.lblMainText2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblMainText2]));
		w4.X = 199;
		w4.Y = 158;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnClickMe.Clicked += new global::System.EventHandler(this.ButtonClickMe_clicked);
	}
}
