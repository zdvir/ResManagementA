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
    public partial class SettingsControl : UserControl
    {
        private String currentUser;
        private User user,userBefore;
        private DBHandler dbHandler;

        public SettingsControl()
        {
            InitializeComponent();
            dbHandler = new DBHandler();
        }

        public void SetCurrentUser(String username)
        {
            this.currentUser = username;
            user = dbHandler.GetUserDetails(currentUser);
            userBefore = user.DeepCopy(); //ProtoType Design - User Before Changes
        }

        public void GetOrRefreshData()
        {
            PhoneTxt.Text = "0"+user.PhoneNumber.ToString();
            EmailTxt.Text = user.Email.ToString();
        }

        private void ClearBtn1_Click(object sender, EventArgs e)
        {
            Clear1();
        }
        private void Clear1()
        {
            ConfirmPassTxt.Text = "";
            NewPassTxt.Text = "";
            OldPassTxt.Text = "";
        }

        private void ClearBtn2_Click(object sender, EventArgs e)
        {
            Clear2();
        }
        private void Clear2()
        {
            PasswordTxt.Text = "";
            PhoneTxt.Text = "";
            EmailTxt.Text = "";
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
           if(user.Password.Equals(OldPassTxt.Text))
            {
                if ((ConfirmPassTxt.Text).Equals(NewPassTxt.Text))
                {
                    dbHandler.UpdateUser(new User(user.UserName, NewPassTxt.Text, user.Permission,
                                                  user.FirstName, user.LastName,
                                                  user.Email, user.PhoneNumber, user.Age));
                    Clear1();
                    MessageBox.Show("Update Password Successful");
                }
                else
                    MessageBox.Show("Not Saved. The New Password not Equals to Confirm Password");
            }
           else
                MessageBox.Show("You Entered Wrong Password");   
        }


        private void SaveBtn2_Click(object sender, EventArgs e)
        {
            if (user.Password.Equals(PasswordTxt.Text))
            {
                dbHandler.UpdateUser(new User(user.UserName, user.Password, user.Permission,
                                             user.FirstName, user.LastName,
                                             EmailTxt.Text, Convert.ToInt32(PhoneTxt.Text), user.Age));
                Clear2();
                MessageBox.Show("Update Successful");
            }
            else
                MessageBox.Show("You Entered Wrong Password");
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            Undo();
        }

        public void Undo()
        {
            PhoneTxt.Text = "0" + userBefore.PhoneNumber.ToString();
            EmailTxt.Text = userBefore.Email.ToString();
        }
    }

}
