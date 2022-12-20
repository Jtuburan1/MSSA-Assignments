namespace Assignment4._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentInfoDisplay = new System.Windows.Forms.DataGridView();
            this.StudentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthOfAdmissionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.StudentIDTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.GradeTxt = new System.Windows.Forms.TextBox();
            this.StudentIDLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.MonthOfAdmLbl = new System.Windows.Forms.Label();
            this.MonthOfAdmDropDown = new System.Windows.Forms.ComboBox();
            this.GradeLbl = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.BtnDeleteStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInfoDisplay
            // 
            this.StudentInfoDisplay.AllowUserToAddRows = false;
            this.StudentInfoDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIDColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.AddressColumn,
            this.MonthOfAdmissionColumn,
            this.GradeColumn});
            this.StudentInfoDisplay.Location = new System.Drawing.Point(12, 267);
            this.StudentInfoDisplay.Name = "StudentInfoDisplay";
            this.StudentInfoDisplay.ReadOnly = true;
            this.StudentInfoDisplay.RowHeadersVisible = false;
            this.StudentInfoDisplay.RowHeadersWidth = 150;
            this.StudentInfoDisplay.RowTemplate.Height = 25;
            this.StudentInfoDisplay.Size = new System.Drawing.Size(770, 292);
            this.StudentInfoDisplay.TabIndex = 8;
            this.StudentInfoDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentIDColumn
            // 
            this.StudentIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentIDColumn.HeaderText = "StudentID";
            this.StudentIDColumn.Name = "StudentIDColumn";
            this.StudentIDColumn.ReadOnly = true;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstNameColumn.HeaderText = "First Name";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastNameColumn.HeaderText = "LastName";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // MonthOfAdmissionColumn
            // 
            this.MonthOfAdmissionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MonthOfAdmissionColumn.HeaderText = "Month Of Admission";
            this.MonthOfAdmissionColumn.Name = "MonthOfAdmissionColumn";
            this.MonthOfAdmissionColumn.ReadOnly = true;
            // 
            // GradeColumn
            // 
            this.GradeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradeColumn.HeaderText = "Grade";
            this.GradeColumn.Name = "GradeColumn";
            this.GradeColumn.ReadOnly = true;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(326, 121);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(100, 23);
            this.FirstNameTxt.TabIndex = 1;
            // 
            // StudentIDTxt
            // 
            this.StudentIDTxt.Location = new System.Drawing.Point(326, 75);
            this.StudentIDTxt.Name = "StudentIDTxt";
            this.StudentIDTxt.Size = new System.Drawing.Size(100, 23);
            this.StudentIDTxt.TabIndex = 0;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(326, 168);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(100, 23);
            this.LastNameTxt.TabIndex = 2;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(596, 80);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(158, 23);
            this.AddressTxt.TabIndex = 3;
            // 
            // GradeTxt
            // 
            this.GradeTxt.Location = new System.Drawing.Point(596, 168);
            this.GradeTxt.Name = "GradeTxt";
            this.GradeTxt.Size = new System.Drawing.Size(100, 23);
            this.GradeTxt.TabIndex = 5;
            // 
            // StudentIDLbl
            // 
            this.StudentIDLbl.AutoSize = true;
            this.StudentIDLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentIDLbl.Location = new System.Drawing.Point(218, 75);
            this.StudentIDLbl.Name = "StudentIDLbl";
            this.StudentIDLbl.Size = new System.Drawing.Size(94, 25);
            this.StudentIDLbl.TabIndex = 5;
            this.StudentIDLbl.Text = "StudentID";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLbl.Location = new System.Drawing.Point(218, 121);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(102, 25);
            this.FirstNameLbl.TabIndex = 6;
            this.FirstNameLbl.Text = "First Name";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLbl.Location = new System.Drawing.Point(218, 168);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(100, 25);
            this.LastNameLbl.TabIndex = 7;
            this.LastNameLbl.Text = "Last Name";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLbl.Location = new System.Drawing.Point(481, 80);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(79, 25);
            this.AddressLbl.TabIndex = 8;
            this.AddressLbl.Text = "Address";
            // 
            // MonthOfAdmLbl
            // 
            this.MonthOfAdmLbl.AutoSize = true;
            this.MonthOfAdmLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthOfAdmLbl.Location = new System.Drawing.Point(445, 121);
            this.MonthOfAdmLbl.Name = "MonthOfAdmLbl";
            this.MonthOfAdmLbl.Size = new System.Drawing.Size(145, 20);
            this.MonthOfAdmLbl.TabIndex = 9;
            this.MonthOfAdmLbl.Text = "Month Of Admission";
            // 
            // MonthOfAdmDropDown
            // 
            this.MonthOfAdmDropDown.DisplayMember = "Enum Months";
            this.MonthOfAdmDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthOfAdmDropDown.FormattingEnabled = true;
            this.MonthOfAdmDropDown.Location = new System.Drawing.Point(596, 123);
            this.MonthOfAdmDropDown.Name = "MonthOfAdmDropDown";
            this.MonthOfAdmDropDown.Size = new System.Drawing.Size(121, 23);
            this.MonthOfAdmDropDown.TabIndex = 4;
            this.MonthOfAdmDropDown.ValueMember = "Months.Month";
            this.MonthOfAdmDropDown.SelectedIndexChanged += new System.EventHandler(this.MonthOfAdmDropDown_SelectedIndexChanged);
            // 
            // GradeLbl
            // 
            this.GradeLbl.AutoSize = true;
            this.GradeLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GradeLbl.Location = new System.Drawing.Point(481, 168);
            this.GradeLbl.Name = "GradeLbl";
            this.GradeLbl.Size = new System.Drawing.Size(63, 25);
            this.GradeLbl.TabIndex = 11;
            this.GradeLbl.Text = "Grade";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(259, 222);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(116, 23);
            this.AddStudentButton.TabIndex = 6;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // BtnDeleteStudent
            // 
            this.BtnDeleteStudent.Location = new System.Drawing.Point(445, 222);
            this.BtnDeleteStudent.Name = "BtnDeleteStudent";
            this.BtnDeleteStudent.Size = new System.Drawing.Size(115, 23);
            this.BtnDeleteStudent.TabIndex = 12;
            this.BtnDeleteStudent.Text = "Delete Student";
            this.BtnDeleteStudent.UseVisualStyleBackColor = true;
            this.BtnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.BtnDeleteStudent);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.GradeLbl);
            this.Controls.Add(this.MonthOfAdmDropDown);
            this.Controls.Add(this.MonthOfAdmLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.StudentIDLbl);
            this.Controls.Add(this.GradeTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.StudentIDTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.StudentInfoDisplay);
            this.Name = "Form1";
            this.Text = "Student Info";
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView StudentInfoDisplay;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FirstName;
        private TextBox FirstNameTxt;
        private TextBox StudentIDTxt;
        private TextBox LastNameTxt;
        private TextBox AddressTxt;
        private TextBox GradeTxt;
        private Label StudentIDLbl;
        private Label FirstNameLbl;
        private Label LastNameLbl;
        private Label AddressLbl;
        private Label MonthOfAdmLbl;
        private ComboBox MonthOfAdmDropDown;
        private Label GradeLbl;
        private Button AddStudentButton;
        private DataGridViewTextBoxColumn StudentIDColumn;
        private DataGridViewTextBoxColumn FirstNameColumn;
        private DataGridViewTextBoxColumn LastNameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn MonthOfAdmissionColumn;
        private DataGridViewTextBoxColumn GradeColumn;
        private Button BtnDeleteStudent;
    }
}