namespace StudentManagementSystem.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();  
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 400);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Orange; // Orange background
            this.btnAdd.ForeColor = System.Drawing.Color.White; // White text
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold); // Increased font size and bold text
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 1; // Border remains
            this.btnAdd.Location = new System.Drawing.Point(12, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40); // Initial size
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange; // Orange background
            this.btnDelete.ForeColor = System.Drawing.Color.White; // White text
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold); // Increased font size and bold text
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 1; // Border remains
            this.btnDelete.Location = new System.Drawing.Point(697, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40); // Initial size
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange; // Orange background
            this.btnUpdate.ForeColor = System.Drawing.Color.White; // White text
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold); // Increased font size and bold text
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 1; // Border remains
            this.btnUpdate.Location = new System.Drawing.Point(93, 430);  
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40); // Initial size
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51); // #333 background for the form
            this.Controls.Add(this.btnUpdate); // Added btnUpdate to Controls collection
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.Resize += new System.EventHandler(this.MainForm_Resize); // Event for form resizing
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;

        private void MainForm_Resize(object sender, EventArgs e)
{
    // Adjust button sizes dynamically based on form size
    int formWidth = this.ClientSize.Width;
    int buttonWidth = (formWidth - 40) / 3; // 3 buttons, 40px total padding

    // Adjust buttons to be responsive
    btnAdd.Size = new System.Drawing.Size(buttonWidth, 40);
    btnDelete.Size = new System.Drawing.Size(buttonWidth, 40);
    btnUpdate.Size = new System.Drawing.Size(buttonWidth, 40);

    // Reposition buttons with added margin at the top
    btnAdd.Location = new System.Drawing.Point(12, 430 + 40); // Add margin of 10px
    btnUpdate.Location = new System.Drawing.Point(btnAdd.Right + 10, 430 + 40); // Same margin for Update
    btnDelete.Location = new System.Drawing.Point(btnUpdate.Right + 10, 430 + 40); // Same margin for Delete
}

    }
}
