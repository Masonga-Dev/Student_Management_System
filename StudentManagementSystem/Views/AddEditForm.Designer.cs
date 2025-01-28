namespace StudentManagementSystem.Views
{
    partial class AddEditForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.ForeColor = System.Drawing.Color.Gray; // Placeholder text color
            this.txtName.Text = "Enter Name"; // Placeholder text
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 70);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 1;
            this.txtAge.ForeColor = System.Drawing.Color.Gray; // Placeholder text color
            this.txtAge.Text = "Enter Age"; // Placeholder text
            this.txtAge.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(90, 110);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(200, 20);
            this.txtGrade.TabIndex = 2;
            this.txtGrade.ForeColor = System.Drawing.Color.Gray; // Placeholder text color
            this.txtGrade.Text = "Enter Grade"; // Placeholder text
            this.txtGrade.Enter += new System.EventHandler(this.txtGrade_Enter);
            this.txtGrade.Leave += new System.EventHandler(this.txtGrade_Leave);
            // 
// btnSave
// 
this.btnSave.Location = new System.Drawing.Point(215, 150);
this.btnSave.Name = "btnSave";
this.btnSave.Size = new System.Drawing.Size(90, 40); // Increased size
this.btnSave.TabIndex = 3;
this.btnSave.Text = "Save";
this.btnSave.UseVisualStyleBackColor = true;
this.btnSave.BackColor = System.Drawing.Color.Orange; // Orange background
this.btnSave.ForeColor = System.Drawing.Color.White; // White text
this.btnSave.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold); // Larger, bold font
this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style for custom borders
this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White; // White border
this.btnSave.FlatAppearance.BorderSize = 2; // Border thickness
this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            this.label1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Bold font
            this.label1.ForeColor = System.Drawing.Color.White; // White text color
            this.label1.BackColor = System.Drawing.Color.FromArgb(51, 51, 51); // #333 background color
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age:";
            this.label2.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Bold font
            this.label2.ForeColor = System.Drawing.Color.White; // White text color
            this.label2.BackColor = System.Drawing.Color.FromArgb(51, 51, 51); // #333 background color
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grade:";
            this.label3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Bold font
            this.label3.ForeColor = System.Drawing.Color.White; // White text color
            this.label3.BackColor = System.Drawing.Color.FromArgb(51, 51, 51); // #333 background color
            // 
            // AddEditForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "AddEditForm";
            this.Text = "Add/Edit Student";
            this.BackColor = System.Drawing.Color.Tomato; // Tomato background color
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Event Handlers for placeholder text
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Enter Name")
            {
                txtName.Text = "";
                txtName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Enter Name";
                txtName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "Enter Age")
            {
                txtAge.Text = "";
                txtAge.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                txtAge.Text = "Enter Age";
                txtAge.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtGrade_Enter(object sender, EventArgs e)
        {
            if (txtGrade.Text == "Enter Grade")
            {
                txtGrade.Text = "";
                txtGrade.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtGrade_Leave(object sender, EventArgs e)
        {
            if (txtGrade.Text == "")
            {
                txtGrade.Text = "Enter Grade";
                txtGrade.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
