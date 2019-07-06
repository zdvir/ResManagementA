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
    public partial class FoodMenuForm : Form
    {
        private readonly String NEW_ORDER = "NEW_ORDER", UPDATE_ORDER = "UPDATE_ORDER";
        private int currentTable = 0;
        private String currentMode = "";
        private String currentUser;
        private DBHandler dbHandler;

        public FoodMenuForm(int currenttable, String currentMode,String user)
        {
            InitializeComponent();

            this.currentTable = currenttable;
            this.currentMode = currentMode;
            this.currentUser = user;

            dbHandler = new DBHandler();
            SetCurrentAttributes();

            if(currentMode.Equals(UPDATE_ORDER))
            {
                SetUserControlsToUpdateMode();
            }

        }

        // Menu - Burgers Button Clicked
        private void BurgersBtn_Click(object sender, EventArgs e)
        {
            burgersMenuControl1.BringToFront();
            BlueButtons(BurgersBtn); 
        }

        // Menu - Salads Button Clicked

        private void SaladsBtn_Click(object sender, EventArgs e)
        {
            saladsMenuControl1.BringToFront();
            BlueButtons(SaladsBtn);
        }

        // Menu - Beverages Button Clicked
        private void BeveragesBtn_Click(object sender, EventArgs e)
        {
            beveragesMenuControl1.BringToFront();
            BlueButtons(BeveragesBtn);
        }

        // Menu - Sides Button Clicked
        private void SidesBtn_Click(object sender, EventArgs e)
        {
            sidesMenuControl1.BringToFront();    
            BlueButtons(SidesBtn);
        }

        //The Clicked button will be DarkSlateBlue and the others Blue
        private void BlueButtons(Button button)
        {
            button.BackColor = Color.MediumSlateBlue;

            switch(button.Name)
            {
                case "BurgersBtn":
                    SaladsBtn.BackColor = Color.DodgerBlue;
                    BeveragesBtn.BackColor = Color.DodgerBlue;
                    SidesBtn.BackColor = Color.DodgerBlue;
                    break;

                case "SaladsBtn":
                    BurgersBtn.BackColor = Color.DodgerBlue;
                    BeveragesBtn.BackColor = Color.DodgerBlue;
                    SidesBtn.BackColor = Color.DodgerBlue;
                    break;

                case "BeveragesBtn":
                    SaladsBtn.BackColor = Color.DodgerBlue;
                    BurgersBtn.BackColor = Color.DodgerBlue;
                    SidesBtn.BackColor = Color.DodgerBlue;
                    break;

                case "SidesBtn":
                    SaladsBtn.BackColor = Color.DodgerBlue;
                    BeveragesBtn.BackColor = Color.DodgerBlue;
                    BurgersBtn.BackColor = Color.DodgerBlue;
                    break;

            }
        }

        //Clear all the choosen products (Clear Numeric Values)
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            burgersMenuControl1.ClearNumericValues();
            saladsMenuControl1.ClearNumericValues();
            sidesMenuControl1.ClearNumericValues();
            beveragesMenuControl1.ClearNumericValues();
        }

        // Finish Button Clicked 
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            //If Table mode is Occupied -> Can update the Orders
            if(currentMode.Equals(UPDATE_ORDER))
            {
                //Delete all orders in the Current Table
                DeleteOrders();
               
                //Now Create New order with the updated details
                UpdateOrders();
            }

            // If the table is free -> open New Order
            else if(currentMode.Equals(NEW_ORDER))
            {
                // Just 1 "|" (or) because i want to run all the Methods anyway
                if (burgersMenuControl1.NewOrder() | saladsMenuControl1.NewOrder() |
                    sidesMenuControl1.NewOrder() | beveragesMenuControl1.NewOrder())
                {
                    MessageBox.Show("New Order Successfully Recieved");
                    currentMode = UPDATE_ORDER;
                    dbHandler.UpdateTableMode(currentTable, currentMode);
                }
                else
                {
                    MessageBox.Show("Failed. No Order Recieved");
                }
                
            }
            this.Close();
        }

        //Set the Current Attributes for all the Menu User Controls
        private void SetCurrentAttributes()
        {
            burgersMenuControl1.SetTableNumber(currentTable);
            sidesMenuControl1.SetTableNumber(currentTable);
            saladsMenuControl1.SetTableNumber(currentTable);
            beveragesMenuControl1.SetTableNumber(currentTable);

            burgersMenuControl1.SetCurrentMode(currentMode);
            sidesMenuControl1.SetCurrentMode(currentMode);
            saladsMenuControl1.SetCurrentMode(currentMode);
            beveragesMenuControl1.SetCurrentMode(currentMode);

            burgersMenuControl1.SetCurrentUser(currentUser);
            sidesMenuControl1.SetCurrentUser(currentUser);
            saladsMenuControl1.SetCurrentUser(currentUser);
            beveragesMenuControl1.SetCurrentUser(currentUser);
        }

        //Set the Numeric Values in the Controls
        private void SetUserControlsToUpdateMode()
        {
            burgersMenuControl1.SetNumericValue();
            saladsMenuControl1.SetNumericValue();
            beveragesMenuControl1.SetNumericValue();
            sidesMenuControl1.SetNumericValue();
        }

        //Delete Orders Method in Controls
        private void DeleteOrders()
        {
            burgersMenuControl1.DeleteOrder();
            saladsMenuControl1.DeleteOrder();
            sidesMenuControl1.DeleteOrder();
            beveragesMenuControl1.DeleteOrder();
        }
        
        //Update the Orders in the controls
        private void UpdateOrders()
        {
            burgersMenuControl1.UpdateOrder();
            saladsMenuControl1.UpdateOrder();
            sidesMenuControl1.UpdateOrder();
            beveragesMenuControl1.UpdateOrder();
        }
    }
}
