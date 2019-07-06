using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ResManagement.Classes;

namespace ResManagement.Forms
{
    public partial class LoginForm : Form
    {
        private DBHandler dbHandler;

        public LoginForm()
        {
            InitializeComponent();
        }

        //Login button click handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler = new DBHandler();
                bool result = dbHandler.IsCorrectUsernameAndPassword(txtUsername.Text, txtPassword.Text);

                // If the User is exists in the Database -> Open the Menu Form
                if (result)
                {
                    CurrentUser.Instance.UserName = txtUsername.Text;
                    Hide();
                    Forms.MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    mainForm = null;
                    Show();
                }
               
                else 
                {
                    MessageBox.Show("Incorrect Username or Passsword");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        //Exit button click handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
