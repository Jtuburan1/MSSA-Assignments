using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._3
{
    public partial class NewStudentPopup : Form
    {
        public NewStudentPopup()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            newStudent.StudentID = txtStudentID.Text;
            newStudent.StudentName = txtStudentName.Text;
            newStudent.GPA = decimal.Parse(txtGPA.Text);

            DataSource.Students.Add(newStudent);

            Hide();
        }
    }
}
