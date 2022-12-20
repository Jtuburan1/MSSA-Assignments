using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace Assignment5._3
{
    public partial class StudentsPage : Form
    {
        public StudentsPage()
        {
            InitializeComponent();
            LogonPage log = new LogonPage();
            log.ShowDialog();
            DataSource.CreateData();
            Refresh();
        }

        public override void Refresh()
        {
            dataGridView1.Rows.Clear();
            foreach (Student student in DataSource.Students)
            {
                dataGridView1.Rows.Add(student.StudentID, student.StudentName, student.GPA);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                NewStudentPopup sd = new NewStudentPopup();
                sd.ShowDialog();
                Refresh();                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating new student", MessageBoxButtons.OK);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int selectedRow = dataGridView1.SelectedRows.Count;
            if(selectedRow > 0)
            {
                var row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                dataGridView1.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON documents|*.json";
                dialog.FileName = "Highest GPA";
                dialog.DefaultExt = ".json";

                // TODO: Exercise 1: Task 1b: Store the return value from the SaveFileDialog in a nullable Boolean variable.
                bool? result = Convert.ToBoolean(dialog.ShowDialog());
                if (result.HasValue && result.Value)
                {
                    decimal highestGPA = (decimal)DataSource.Students.Max(t => t.GPA);
                    // TODO: Exercise 1: Task 1c: Get the grades for the currently selected student.
                    List<Student> GPA = (from g in DataSource.Students
                                          where g.GPA == highestGPA
                                          select g).ToList();
                    // TODO: Exercise 1: Task 2: Serialize the grades to a JSON.
                    var GPAAsJson = JsonConvert.SerializeObject(GPA, Newtonsoft.Json.Formatting.Indented);
                    //TODO: Exercise 1: Task 3a: Modify the message box and ask the user whether they wish to save the report
                    DialogResult reply = MessageBox.Show(GPAAsJson, "Save Report?", MessageBoxButtons.YesNoCancel);
                    //TODO: Exercise 1: Task 3b: Check if the user what to save the report or not
                    if (reply == DialogResult.Yes)
                    {
                        //TODO: Exercise 1: Task 3c: Save the data to the file by using FileStream
                        FileStream file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter streamWriter = new StreamWriter(file);
                        streamWriter.Write(GPAAsJson);
                        file.Position = 0;
                        //TODO: Exercise 1: Task 3d: Release all the stream resources
                        streamWriter.Close();
                        streamWriter.Dispose();

                        file.Close();
                        file.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Generating Report", MessageBoxButtons.OK);
            }
        }
    }
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public decimal? GPA { get; set; }  
    }

    public class Teacher
    {
        public string UserID { get; set; }
        public string Password { get; set; }

    }
}
