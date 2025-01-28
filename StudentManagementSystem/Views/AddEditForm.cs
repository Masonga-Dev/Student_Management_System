using System;
using System.Windows.Forms;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Views
{
    public partial class AddEditForm : Form
    {
        private int _studentId;

        // Constructor for adding new student
        public AddEditForm()
        {
            InitializeComponent();
        }

        // Constructor for editing existing student
        public AddEditForm(int studentId, string name, int age, string grade)
        {
            InitializeComponent();
            _studentId = studentId;  // Store student ID for updating
            txtName.Text = name;  // Fill fields with existing data
            txtAge.Text = age.ToString();
            txtGrade.Text = grade;
        }

        private void btnSave_Click(object sender, EventArgs e)
{
    // Check if Age and Grade are valid before proceeding
    if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtGrade.Text) || string.IsNullOrEmpty(txtAge.Text))
    {
        MessageBox.Show("Please fill all fields.");
        return;
    }

    var student = new Student(_studentId, txtName.Text, Convert.ToInt32(txtAge.Text), txtGrade.Text);  // Pass the required arguments

    if (_studentId == 0)  // If StudentID is 0, it's a new student, so insert
    {
        DatabaseHelper.AddStudent(student);
    }
    else  // If StudentID is not 0, update the existing student
    {
        DatabaseHelper.UpdateStudent(student);
    }

    this.Close();  // Close the form after saving
}
    }

}
