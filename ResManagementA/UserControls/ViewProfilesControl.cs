using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManagement.Classes;

namespace ResManagement.UserControls
{
    public partial class ViewProfilesControl : UserControl
    {
        private DBHandler dbHandler;
        private List<User> usersList;
        private static ListViewItem listViewItem, listViewHiddenPassword;
        private TextBox[] textBoxArray;
        private String currentUser;

        public ViewProfilesControl()
        {
            InitializeComponent();

            dbHandler = new DBHandler();
            GetOrRefreshData();

            textBoxArray = this.Controls.OfType<TextBox>().ToArray();
            Array.Reverse(textBoxArray);

            domainUpDown1.Items.Add("Admin");
            domainUpDown1.Items.Add("Employee");
        }

        private void ButtonsEnabled(bool x)
        {
            foreach (TextBox t in textBoxArray)
                t.Enabled = x;
            SaveChangesBtn.Enabled = x;
            domainUpDown1.Enabled = x;
            DeleteUserBtn.Enabled = x;

            //If the user is not Admin, Hide password and Username fields
            listView1.Visible = x;
            listView2.Visible = !x;

            listView2.Location = new Point(25, 108);
            listView2.Size = new Size(970, 470);
        }

        //Get the Data from DB 
        public void GetOrRefreshData()
        {
            //Get the Users List
            usersList = dbHandler.GetUsersList();

            //Remove all items to clean the listView
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();

            //Build the listView and add Users details
            foreach (User user in usersList)
            {
                listViewItem = new ListViewItem(user.UserName);
                listViewItem.SubItems.Add(user.FirstName);
                listViewItem.SubItems.Add(user.LastName);
                listViewItem.SubItems.Add(user.Password);
                listViewItem.SubItems.Add("0"+Convert.ToString(user.PhoneNumber));
                listViewItem.SubItems.Add(user.Email);
                listViewItem.SubItems.Add(Convert.ToString(user.Age));
                listViewItem.SubItems.Add(Convert.ToString(user.Permission));

                listView1.Items.Add(listViewItem);

                listViewHiddenPassword = new ListViewItem("*****");
                listViewHiddenPassword.SubItems.Add(user.FirstName);
                listViewHiddenPassword.SubItems.Add(user.LastName);
                listViewHiddenPassword.SubItems.Add("*****");
                listViewHiddenPassword.SubItems.Add("0" + Convert.ToString(user.PhoneNumber));
                listViewHiddenPassword.SubItems.Add(user.Email);
                listViewHiddenPassword.SubItems.Add(Convert.ToString(user.Age));
                listViewHiddenPassword.SubItems.Add(Convert.ToString(user.Permission));

                listView2.Items.Add(listViewHiddenPassword);
            }
           
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            User user = updateUserDetails();
            dbHandler.UpdateUser(user);
            GetOrRefreshData();
            MessageBox.Show("User Details Updated Successfuly");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;

            textBoxArray[0].Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxArray[1].Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxArray[2].Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxArray[3].Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxArray[4].Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBoxArray[5].Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxArray[6].Text = listView1.SelectedItems[0].SubItems[6].Text;

            String permission = listView1.SelectedItems[0].SubItems[7].Text;
            if (permission.Equals("1"))
                domainUpDown1.Text = "Admin";
            else
                domainUpDown1.Text = "Employee";
        }

        private User updateUserDetails()
        {
            User user;
            user = new User(textBoxArray[0].Text, textBoxArray[3].Text);
            user.FirstName = textBoxArray[1].Text;
            user.LastName = textBoxArray[2].Text;
            user.Email = textBoxArray[5].Text;
            user.PhoneNumber = Int32.Parse(textBoxArray[4].Text);
            user.Age = Int32.Parse(textBoxArray[6].Text);

            if ((domainUpDown1.Text).Equals("Admin"))
                user.Permission = 1;
            else if ((domainUpDown1.Text).Equals("Employee"))
                user.Permission = 0;

            return user;
        }


        //KeyPress handler for PhoneNumber and Age fields
        private void KeyPressNumbersOnly(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            //Permitted chars will be BackSpace<- or Digits only
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        //Delete User from Users List 
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;

            if (dbHandler.DeleteUser(username) == 1)
                MessageBox.Show("User Deleted Successfuly");
            else
                MessageBox.Show("Not Deleted");

            GetOrRefreshData();
        }

        public void SetCurrentUser(String user)
        {
            this.currentUser = user;

            //Give Admin Permissions
            if (dbHandler.IsAdmin(currentUser))
                ButtonsEnabled(true);
            else
            {
                ButtonsEnabled(false);
            }

        }
    }
}
