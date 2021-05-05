
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label Header;

	private global::Gtk.Button btnUpdate;

	private global::Gtk.Button btnDelete;

	private global::Gtk.Button btnAdd;

	private global::Gtk.Entry FirstName;

	private global::Gtk.Entry jobTitle;

	private global::Gtk.Label labFname;

	private global::Gtk.Label labJobTitle;

	private global::Gtk.Label label5;

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
		this.Header = new global::Gtk.Label();
		this.Header.Name = "Header";
		this.Header.LabelProp = global::Mono.Unix.Catalog.GetString("Employee Directory");
		this.fixed1.Add(this.Header);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.Header]));
		w1.X = 132;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnUpdate = new global::Gtk.Button();
		this.btnUpdate.CanFocus = true;
		this.btnUpdate.Name = "btnUpdate";
		this.btnUpdate.UseUnderline = true;
		this.btnUpdate.Label = global::Mono.Unix.Catalog.GetString("Update");
		this.fixed1.Add(this.btnUpdate);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnUpdate]));
		w2.X = 159;
		w2.Y = 233;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnDelete = new global::Gtk.Button();
		this.btnDelete.CanFocus = true;
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.UseUnderline = true;
		this.btnDelete.Label = global::Mono.Unix.Catalog.GetString("Delete");
		this.fixed1.Add(this.btnDelete);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnDelete]));
		w3.X = 259;
		w3.Y = 236;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnAdd = new global::Gtk.Button();
		this.btnAdd.CanFocus = true;
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.UseUnderline = true;
		this.btnAdd.Label = global::Mono.Unix.Catalog.GetString("Add");
		this.fixed1.Add(this.btnAdd);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnAdd]));
		w4.X = 77;
		w4.Y = 235;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.FirstName = new global::Gtk.Entry();
		this.FirstName.CanFocus = true;
		this.FirstName.Name = "FirstName";
		this.FirstName.IsEditable = true;
		this.FirstName.InvisibleChar = '●';
		this.fixed1.Add(this.FirstName);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.FirstName]));
		w5.X = 186;
		w5.Y = 64;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.jobTitle = new global::Gtk.Entry();
		this.jobTitle.CanFocus = true;
		this.jobTitle.Name = "jobTitle";
		this.jobTitle.IsEditable = true;
		this.jobTitle.InvisibleChar = '●';
		this.fixed1.Add(this.jobTitle);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.jobTitle]));
		w6.X = 191;
		w6.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labFname = new global::Gtk.Label();
		this.labFname.Name = "labFname";
		this.labFname.LabelProp = global::Mono.Unix.Catalog.GetString("Full Name");
		this.fixed1.Add(this.labFname);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labFname]));
		w7.X = 68;
		w7.Y = 68;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labJobTitle = new global::Gtk.Label();
		this.labJobTitle.Name = "labJobTitle";
		this.labJobTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Job Title");
		this.fixed1.Add(this.labJobTitle);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labJobTitle]));
		w8.X = 64;
		w8.Y = 105;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.fixed1.Add(this.label5);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label5]));
		w9.X = 226;
		w9.Y = 287;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 412;
		this.DefaultHeight = 340;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnAdd.Clicked += new global::System.EventHandler(this.BtnAdd_Click);
	}
}