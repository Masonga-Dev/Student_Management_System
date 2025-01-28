using System;
using System.Windows.Forms;
using StudentManagementSystem.Data;
using StudentManagementSystem.Views;

namespace StudentManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize Database
            DatabaseHelper.InitializeDatabase();

            // Start the application
            Application.Run(new MainForm());
        }
    }
}
