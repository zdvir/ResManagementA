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
using System.Diagnostics;

namespace ResManagement.UserControls
{
    public partial class ViewTableControl : UserControl
    {
        private readonly String NEW_ORDER = "NEW_ORDER", UPDATE_ORDER = "UPDATE_ORDER";
        private readonly int NUMBER_OF_TABLES=11; 
        private DBHandler dbHandler;
        
        private Label[] tableModeLabels;

        private int currentTable = 0;
        private String currentMode = "";
        private String currentUser;

        public ViewTableControl()
        {
            InitializeComponent();
            dbHandler = new DBHandler();

            Label[] temp = new Label[]
            {
                label1, label4,label5,label6,label7,label8,
                label9,label10,label11,label12,label13
            };
            tableModeLabels = temp.ToArray();
            SetTableModeLabels(tableModeLabels);
        }

        //Every TableButtons will show same Order MenuStrip when a button has been clicked 
        public void ButtonClick(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            
            for (int i = 1; i <= NUMBER_OF_TABLES; i++)
            {
                if (myButton.Name.Equals("TableBtn" + i))
                {
                    currentMode = dbHandler.GetTableMode(i);

                    if (currentMode.Equals(NEW_ORDER))
                    { 
                        NewOrderMode();
                    }
                    else if (currentMode.Equals(UPDATE_ORDER))
                    {
                        UpdateOrderMode();
                    }
                    
                    ViewTableMenuStrip.Show(myButton, 0, myButton.Height);
                    currentTable = i;
                }      
            }
              
        }

        //Change the Buttons to New Order Mode
        private void NewOrderMode()
        {
            newOrderToolStripMenuItem.Enabled = true;
            updateOrderToolStripMenuItem.Enabled = false;
            BillToolStripMenuItem.Enabled = false;
            FinishToolStripMenuItem.Enabled = false;

            SetTableModeLabels(tableModeLabels); //Refresh the labels
        }

        //New Order will open FoodMenu Form
        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTable == 0)
                return;

            Forms.FoodMenuForm f = new Forms.FoodMenuForm(currentTable, currentMode,currentUser);
            f.Show();
        }

        // Update Button will open FoodMenu Form
        private void UpdateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTable == 0)
                return;

            Forms.FoodMenuForm f = new Forms.FoodMenuForm(currentTable, currentMode, currentUser);
            f.Show();
        }

        // Bill Button with open Bill Form
        private void BillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BillForm f = new Forms.BillForm(currentTable, currentUser);
            f.GetOrRefreshData();
            f.Show();
        }

        private void FinishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Order And Free The Table?", "Finish", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbHandler.ToOrdersHistory(currentTable);
                dbHandler.DeleteOrder(currentTable);
                currentMode = NEW_ORDER; 
                dbHandler.UpdateTableMode(currentTable,NEW_ORDER);
            }
            SetTableModeLabels();
        }

        //Change the Buttons to Update Mode
        private void UpdateOrderMode()
        {
            newOrderToolStripMenuItem.Enabled = false;
            updateOrderToolStripMenuItem.Enabled = true;
            BillToolStripMenuItem.Enabled = true;
            FinishToolStripMenuItem.Enabled = true;

            SetTableModeLabels(); //Refresh the labels
        }

        //Refresh the labels
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            SetTableModeLabels(); 
        }

        //Set Tables labels: "FREE" or "Occupied"
        private void SetTableModeLabels()
        {
            SetTableModeLabels(tableModeLabels);
        }
        private void SetTableModeLabels(Label[] array)
        {
            for (int i = 1; i <= array.Length; i++)
               if(dbHandler.GetTableMode(i).Equals(NEW_ORDER))
                {
                    array[i-1].Text = "FREE";
                    array[i - 1].ForeColor = Color.Green;
                }
                else
                {                  
                    array[i-1].Text = "Occupied";
                    array[i - 1].ForeColor = Color.Red;
                }
        }

        //Set Current user method
        public void SetCurrentUser(String user)
        {
            this.currentUser = user;
        }
    }
}
