using System;
using Gtk;
using System.Collections.Generic;

namespace EmployeeDir
{
    class MainClass
    {
        static List<Employee> employees = new List<Employee>();
        static int count = 0;
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();

            employees.Add(new Employee("John Smith", "Front Desk"));
            count++;

            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0}, Job Tile: {1}", employee.fname, employee.jobTitle);
            }
            Application.Run();




        }
    }

    class Employee
    {
        public string fname;
        public string jobTitle;

        public Employee(string name, string title)
        {
            fname = name;
            jobTitle = title;
        }

        public string GetName()
        {
            return fname;
        }

        public override string ToString()
        {
            return fname + " " + jobTitle;
        }

    }
}