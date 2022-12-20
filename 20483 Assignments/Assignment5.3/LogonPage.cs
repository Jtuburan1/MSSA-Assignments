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
    public partial class LogonPage : Form
    {
        public LogonPage()
        {
            InitializeComponent();
            DataSource.CreateData();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            string uN = txtUserName.Text;
            string pass = txtPassword.Text;

            var logon = (from Teacher t in DataSource.Teachers
                         where String.Compare(t.UserID, uN) == 0
                         && String.Compare(t.Password, pass) == 0
                         select t).FirstOrDefault();

            if (logon != null && !String.IsNullOrEmpty(logon.UserID))
            {
                MessageBox.Show("Logon Successful.");
                Close();
                return;
            }
            else
            {
                MessageBox.Show("Incorrect logon credentials. Try again.");
            }
        }
    }
}
