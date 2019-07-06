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
    public partial class RegisterControl : UserControl
    {
        private TextBox[] textBoxArray;
        private readonly int ADMIN =1, EMPLOYEE=0;
        private RadioButton currentRB;
        private int userPermission = 0;
        private DBHandler dbHandler;
        private String currentUser="";

        public RegisterControl()
        {
            InitializeComponent();
            dbHandler = new DBHandler();
            textBoxArray = this.Controls.OfType<TextBox>().ToArray();
            Array.Reverse(textBoxArray);
                
        }
        private void ButtonsEnabled(bool x)
        {
            foreach (TextBox t in textBoxArray)
                t.Enabled = x;
            AddBtn.Enabled = x;
            ClearBtn.Enabled = x;
            radioButton1.Enabled = x;
            radioButton2.Enabled = x;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            for (int i = 0; i < textBoxArray.Length; i++)
                textBoxArray[i].Text = "";
            currentRB = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            currentRB = (RadioButton)sender;

            if (currentRB == radioButton1)
                userPermission = ADMIN;

            else if (currentRB == radioButton2)
                userPermission = EMPLOYEE;
        }

        //Check if Permission-RadioButton has clicked
        private bool IsRadioButtonClicked()
        {
            if (currentRB == null)
                return false;
            else
                return true;
        }

        //Submit registeration
        private void AddBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxArray.Length; i++)
                if (textBoxArray[i].Text.Equals(""))
                {
                    MessageBox.Show("Can't Use Empty Fields!");
                    return;
                }

            if (!IsRadioButtonClicked())
            {
                MessageBox.Show("You Must Choose Permittion!");
                return;
            }

            User user = getRegisterDetails();

            int x=0;
            if (!dbHandler.IsUserExists(user))
                x = dbHandler.CreateNewUser(user);

            if (x == 1)
            { 
                MessageBox.Show("New User Created");
                ClearFields();
            }
            else
                MessageBox.Show("User Is Already Exists");
        }

        //KeyPress handler for PhoneNumber and Age fields
        private void KeyPressNumbersOnly(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            //Permitted chars will be BackSpace<- or Digits only
            if (!Char.IsDigit(ch) && ch!=8)
                e.Handled = true;
        }

        //Permitted chars - ALL Without WhiteSpaces
        private void KeyPressNoSpace(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetterOrDigit(ch) && ch != 8  && !Char.IsSymbol(ch) && !Char.IsHighSurrogate(ch) && !Char.IsLowSurrogate(ch) && !Char.IsPunctuation(ch))
                e.Handled = true;
        }

        private User getRegisterDetails()
        {
            User user;
            user = new User(textBoxArray[0].Text, textBoxArray[1].Text);
            user.Permission = userPermission;
            user.Email = textBoxArray[2].Text;
            user.FirstName = textBoxArray[3].Text;
            user.LastName = textBoxArray[4].Text;
            user.PhoneNumber = Int32.Parse(textBoxArray[5].Text);
            user.Age = Int32.Parse(textBoxArray[6].Text);

            return user;
        }

        public void SetCurrentUser(String user)
        {
            this.currentUser = user;

            //Give Admin Permissions
            if (dbHandler.IsAdmin(currentUser))
                 ButtonsEnabled(true);
            else
                ButtonsEnabled(false);
        }
    }
}
