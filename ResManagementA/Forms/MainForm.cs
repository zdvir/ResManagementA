using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManagement.Classes;

namespace ResManagement.Forms
{
    public partial class MainForm : Form
    {
        private String currentUser;
        private DBHandler dbHandler;
        
        public MainForm()
        {
            InitializeComponent();
            dbHandler = new DBHandler();
           
            currentUser = CurrentUser.Instance.UserName;//Get CurrentUser String from singelton
            SetCurrentUserInUserControls(currentUser);
            UserLbl.Text = currentUser.ToUpper();
            UserLbl.ForeColor = Color.Red;

            Timelbl.Text = DateTime.Now.ToLongTimeString();
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        //Left Side Menu - ViewTable Button Clicked
        private void ViewTableBtn_Click(object sender, EventArgs e)
        {
            SetCurrentUserInUserControls(currentUser);
            SidePanel.Height = ViewTableBtn.Height;
            SidePanel.Top = ViewTableBtn.Top;
            viewTableControl2.BringToFront();
        }

        //Left Side Menu - Home Button Clicked

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SetCurrentUserInUserControls(currentUser); 
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;    
            homeControl1.BringToFront();
        }

        //Left Side Menu - Exit Button Clicked
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //Left Side Menu - Inventory Button Clicked
        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            SetCurrentUserInUserControls(currentUser);
            SidePanel.Height = InventoryBtn.Height;
            SidePanel.Top = InventoryBtn.Top;
            inventoryControl1.BringToFront();
            inventoryControl1.GetOrRefreshData();
        }

        //Left Side Menu - Register Button Clicked
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (dbHandler.IsAdmin(currentUser))
            {
                SetCurrentUserInUserControls(currentUser);
                SidePanel.Height = RegisterBtn.Height;
                SidePanel.Top = RegisterBtn.Top;
                registerControl1.BringToFront();
            }
            else
                MessageBox.Show("You Have No Access");
        }

        //Left Side Menu - ViewProfiles Button Clicked
        private void ViewProfilesBtn_Click(object sender, EventArgs e)
        {
            SetCurrentUserInUserControls(currentUser);
            SidePanel.Height = ViewProfilesBtn.Height;
            SidePanel.Top = ViewProfilesBtn.Top;
            viewProfilesControl1.GetOrRefreshData();
            viewProfilesControl1.BringToFront();
        }

        //Set the current user in the Controls
        private void SetCurrentUserInUserControls(String user)
        {
            viewTableControl2.SetCurrentUser(user);
            homeControl1.SetCurrentUser(user);
            inventoryControl1.SetCurrentUser(user);
            registerControl1.SetCurrentUser(user);
            viewProfilesControl1.SetCurrentUser(user);
            settingsControl1.SetCurrentUser(user);
        }

        //Left Side Menu - View History Button Clicked
        private void ViewHistoryBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ViewHistoryBtn.Height;
            SidePanel.Top = ViewHistoryBtn.Top;
            historyControl1.BringToFront();
            historyControl1.GetOrRefreshData();
        }

        //Settings Icon Clicked
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SetCurrentUserInUserControls(currentUser);
            SidePanel.Height = 0;
            SidePanel.Top = SettingsBtn.Top;
            settingsControl1.BringToFront();
            settingsControl1.GetOrRefreshData();
        }

        //Timer for Date and Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            UsernameChangeColors();
            timer1.Start();
        }
        
        //Method: Change the color of the Connected User
        private void UsernameChangeColors()
        {
            if (UserLbl.ForeColor == Color.Red)
                UserLbl.ForeColor = Color.Blue;

            else if (UserLbl.ForeColor == Color.Blue)
                UserLbl.ForeColor = Color.Green;
            else if (UserLbl.ForeColor == Color.Green)
                UserLbl.ForeColor = Color.Pink;
            else if (UserLbl.ForeColor == Color.Pink)
                UserLbl.ForeColor = Color.Sienna;
            else if (UserLbl.ForeColor == Color.Sienna)
                UserLbl.ForeColor = Color.SkyBlue;
            else if (UserLbl.ForeColor == Color.SkyBlue)
                UserLbl.ForeColor = Color.Silver;
            else if (UserLbl.ForeColor == Color.Silver)
                UserLbl.ForeColor = Color.SeaGreen;
            else if (UserLbl.ForeColor == Color.SeaGreen)
                UserLbl.ForeColor = Color.Tomato;
            else if (UserLbl.ForeColor == Color.Tomato)
                UserLbl.ForeColor = Color.White;
            else if (UserLbl.ForeColor == Color.White)
                UserLbl.ForeColor = Color.Yellow;
            else if (UserLbl.ForeColor == Color.Yellow)
                UserLbl.ForeColor = Color.SteelBlue;
            else if (UserLbl.ForeColor == Color.SteelBlue)
                UserLbl.ForeColor = Color.Navy;
            else if (UserLbl.ForeColor == Color.Navy)
                UserLbl.ForeColor = Color.MediumPurple;
            else if (UserLbl.ForeColor == Color.MediumPurple)
                UserLbl.ForeColor = Color.Red;
        }

        //Left Side Menu - LogOut Icon Clicked
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
