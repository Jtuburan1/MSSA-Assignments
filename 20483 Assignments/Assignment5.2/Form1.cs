using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<int, Person> AddressBook = new Dictionary<int, Person>();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            string fname = txtFName.Text;
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            string lname = txtLName.Text;
        }

        private void txtMblNum_TextChanged(object sender, EventArgs e)
        {
            string mblnum = txtMblNum.Text;
        }

        private void txtWrkNum_TextChanged(object sender, EventArgs e)
        {
            string wrknum = txtWrkNum.Text;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddressBook.Add(count, new Person() { FName = txtFName.Text, LName = txtLName.Text, MobileNumber = txtMblNum.Text, WorkNumber = txtWrkNum.Text, Address = txtAddress.Text});
            count++;
            Refresh();
        }

        public override void Refresh()
        {
            dataGridView1.Rows.Clear();
            foreach (KeyValuePair<int, Person> value in AddressBook)
            {
                dataGridView1.Rows.Add(value.Key, value.Value.FName, value.Value.LName, value.Value.MobileNumber, value.Value.WorkNumber, value.Value.Address);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedRows.Count;
            if (selectedRow > 0)
            {
                var row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                if(AddressBook.ContainsKey(row))
                {
                    AddressBook.Remove(row);
                }
                MessageBox.Show("Row Successfully Deleted");
                dataGridView1.Refresh();
                dataGridView1.Parent.Refresh();
            }
            else
            {
                MessageBox.Show("Row was not deleted successfully. Try again.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string nameToBeSearched = txtSearch.Text;
                var values = from person in AddressBook.Values
                             where person.FName.Contains(nameToBeSearched) || person.LName.Contains(nameToBeSearched)
                             select person;

                var result = sb.AppendFormat(values.ToString());
                MessageBox.Show(result.ToString());
            }
            catch
            {
                MessageBox.Show("There is no entry for that person.");
            }
        }
    }

    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string MobileNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Address { get; set; }
    }
}
