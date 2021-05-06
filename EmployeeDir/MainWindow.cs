using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    int count = 0;
    static List<EmployeeDir.Employee> employees = new List<EmployeeDir.Employee>();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void BtnAdd_Click(object sender, EventArgs args)
    {
        employees.Add(new EmployeeDir.Employee(this.FirstName.Text, this.jobTitle.Text));
        count++;

        string combindedString = string.Join("\n", employees);
       
        this.label5.Text ="Name | Job Title\n" + "\n" + combindedString;

    }

    private void BtnUpdate_Click(object sender, EventArgs args)
    {
        this.label5.Text = "Update works";
    }

    private void BtnDelete_Click(object sender, EventArgs args)
    {
        this.label5.Text = "delete works";
    }

}
