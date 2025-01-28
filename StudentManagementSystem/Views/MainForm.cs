using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Views
{
    public partial class MainForm : Form
    {
        private TextBox? txtSearch;  // Declare txtSearch as nullable to match CS8618

public MainForm()
{
    InitializeComponent();
    RefreshData();
    InitializeSearchTextBox();  // Initialize the txtSearch TextBox

    // Set the form to open in full screen (maximized)
    this.WindowState = FormWindowState.Maximized;
}

        private void InitializeSearchTextBox()
        {
            this.txtSearch = new TextBox
            {
                Name = "txtSearch",
                Location = new System.Drawing.Point(12, 430),  // Position the search box below the DataGridView
                Width = 400,
                Height = 50,
                BorderStyle = BorderStyle.FixedSingle,  // Adding a border style
                Font = new System.Drawing.Font("Arial", 12),  // Set font size for better readability
                PlaceholderText = "Search by Name or Grade" // Modern search placeholder text
            };
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            // Add the txtSearch TextBox to the form
            this.Controls.Add(txtSearch);
        }

        private void RefreshData(bool isSearchActive = false)
        {
            // If search is active, we want to keep the filtered data, else load all data
            if (!isSearchActive)
            {
                dataGridView1.DataSource = DatabaseHelper.GetAllStudents();  // Get all students if not searching
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditForm();
            addForm.ShowDialog();  // Show the AddEdit form
            RefreshData();  // Refresh the data in DataGridView after adding
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // If a row is selected in the DataGridView, delete the student
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                DatabaseHelper.DeleteStudent(studentId);
                RefreshData();  // Refresh the data after deleting
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If a row is selected in the DataGridView, open the AddEditForm with selected student data for updating
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                string name = dataGridView1.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "";
                int age = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Age"].Value);
                string grade = dataGridView1.SelectedRows[0].Cells["Grade"].Value?.ToString() ?? "";

                var editForm = new AddEditForm(studentId, name, age, grade);  // Pass student details to Edit form
                editForm.ShowDialog();  // Show the AddEdit form in edit mode
                RefreshData();  // Refresh the data after updating
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
{
    if (txtSearch != null)  // Ensure txtSearch is not null before using it
    {
        string searchTerm = txtSearch.Text.ToLower();  // Get the search text in lowercase

        // Get the complete list of students (assuming this returns a DataTable)
        var allStudents = DatabaseHelper.GetAllStudents();

        // If search term is empty, show all students
        if (string.IsNullOrEmpty(searchTerm))
        {
            dataGridView1.DataSource = allStudents;
            return;
        }

        // Filter the students based on the search term (for Name or Grade)
        var filteredStudents = allStudents
            .AsEnumerable()  // Convert DataTable to IEnumerable
            .Where(s => s.Field<string>("Name")?.ToLower().Contains(searchTerm) == true || 
                        s.Field<string>("Grade")?.ToLower().Contains(searchTerm) == true);

        // Check if there are any results after filtering
        if (filteredStudents.Any())
        {
            // If results exist, update DataGridView with filtered students
            dataGridView1.DataSource = filteredStudents.CopyToDataTable();
        }
        else
        {
            // If no results found, show a message box to notify the user
            MessageBox.Show("No students found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Clear the search input
            txtSearch.Clear();

            // Keep showing all students
            dataGridView1.DataSource = allStudents;  // Optionally, you can clear results here
        }
    }
}

    }
}
