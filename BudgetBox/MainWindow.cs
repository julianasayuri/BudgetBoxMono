using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Click(object sender, EventArgs e)
    {
        entry3.Text = (Convert.ToDecimal(entry2.Text) + Convert.ToDecimal(entry1.Text)).ToString();
    }
}
    