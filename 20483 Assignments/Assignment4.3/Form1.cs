using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment4._3
{
    public partial class Form1 : Form
    {
        enum Months { January, February, March, April, May, June, July, August, September, October, November, December }
        public Form1()
        {
            InitializeComponent();
            MonthOfAdmDropDown.DataSource = Enum.GetValues(typeof(Months));
        }

        struct Student
        {
            private string _studentid;
            private string _firstname;
            private string _lastname;
            private string _address;
            private string _grade;

            public string Studentid { get => _studentid; set => _studentid = value; }
            public string Firstname { get => _firstname; set => _firstname = value; }
            public string Lastname { get => _lastname; set => _lastname = value; }
            public string Address { get => _address; set => _address = value; }
            public string Grade { get => _grade; set => _grade = value; }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddItemsToGrid(string studentID, string fName, string lName, string address, string mnthOfAdm, string grade)
        {
            try
            {
                StudentInfoDisplay.Rows.Add(studentID, fName, lName, address, mnthOfAdm, grade);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddItemsToGrid(StudentIDTxt.Text, FirstNameTxt.Text, LastNameTxt.Text, AddressTxt.Text, MonthOfAdmDropDown.Text, GradeTxt.Text);
            Student std = new Student();
            std.Studentid = StudentIDTxt.ToString();
            std.Firstname = FirstNameTxt.ToString();
            std.Lastname = LastNameTxt.ToString();
            std.Address = AddressTxt.ToString();
            std.Grade = GradeTxt.ToString();
            StudentIDTxt.Clear();
            FirstNameTxt.Clear();
            LastNameTxt.Clear();
            AddressTxt.Clear();
            MonthOfAdmDropDown.ResetText();
            GradeTxt.Clear();
        }

        private void MonthOfAdmDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Months month;
            Enum.TryParse<Months>(MonthOfAdmDropDown.SelectedValue.ToString(), out month);
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in StudentInfoDisplay.SelectedCells)
            {
                if (oneCell.Selected)
                    StudentInfoDisplay.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}