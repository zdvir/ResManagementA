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
using System.Data.SqlClient;
using System.IO;


namespace ResManagement.UserControls
{
    public partial class SaladsMenuControl : UserControl, MenuInterface
    {
        private readonly String NEW_ORDER = "NEW_ORDER", UPDATE_ORDER = "UPDATE_ORDER";
        private String TABLE_SALADS = "SaladsTable";
        private DBHandler dbHandler;
        private TextBox[] textBoxArray;
        private Button[] buttonArray;
        private NumericUpDown[] numericUpDownArray;
        private PictureBox[] pictureBoxArray;
        private Product[] saladsArray;
        private int[] numericUpdateModeArray = new int[6];

        private int currentTable = 0;
        private String currentMode = "";
        private String currentUser;

        public SaladsMenuControl()
        {
            InitializeComponent();
            dbHandler = new DBHandler();
            buttonArray = new Button[] { button1, button2, button3, button4, button5, button6 };
            numericUpDownArray = new NumericUpDown[] { numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6 };
            pictureBoxArray = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            textBoxArray = Controls.OfType<TextBox>().ToArray();
           
            Array.Reverse(textBoxArray);

            saladsArray = dbHandler.GetProductList(TABLE_SALADS).ToArray();
            GetOrRefreshData();
            SetNumericMaxValue();
        }

        //Get the Data from DB to the controls
        private void GetOrRefreshData()
        {
            for (int i = 0; i < saladsArray.Length; i++)
            {
                byte[] image = saladsArray[i].Image;
                if (image == null)
                {
                    pictureBoxArray[i].Image = null;
                }
                else
                {
                    MemoryStream m = new MemoryStream(image);
                    pictureBoxArray[i].Image = Image.FromStream(m);
                }
                textBoxArray[i].Text = saladsArray[i].Stocks.ToString();
                textBoxArray[i + 6].Text = saladsArray[i].Price.ToString();
            }
        }

        private void SetNumericMaxValue()
        {
          
            for (int i = 0; i < numericUpDownArray.Length; i++)
                    numericUpDownArray[i].Maximum = saladsArray[i].Stocks; 
        }

        //Update Mode: Set the numeric value of the orders
        public void SetNumericValue()
        {
            List<Order> orderList = dbHandler.GetOrdersList(currentTable);
            foreach (Order order in orderList)
                for (int i = 0; i < saladsArray.Length; i++)
                {
                    if (order.ProductName.Equals(saladsArray[i].Name))
                    {
                        //Save the numeric value before update
                        numericUpdateModeArray[i] = order.Quantity;

                        //fix the Maximum value (how much quantity can return) 
                        numericUpDownArray[i].Maximum = saladsArray[i].Stocks + numericUpdateModeArray[i];

                        //Show the numeric value before update at the NumericButtons
                        numericUpDownArray[i].Value = order.Quantity;
                    }
                }
        }

        public void ClearNumericValues()
        {
            for (int i = 0; i < numericUpDownArray.Length; i++)
                numericUpDownArray[i].Value = 0;
        }

        public bool NewOrder()
        {
            GetOrRefreshData(); //Refresh the data before update

            int numericValue;
            int positiveStocks = 0; //Check if the product stock number is positive
            bool isChanged = false; //Check if there is any changes (If the order include products)

            Order[] orderList = new Order[saladsArray.Length];

            for (int i = 0; i < saladsArray.Length; i++)
            {
                numericValue = Convert.ToInt32(numericUpDownArray[i].Value);

                //Get the Correct Product Stock (Plus the "Before", Minus the "After")
                positiveStocks = saladsArray[i].Stocks - numericValue;

                if (numericValue != 0 && positiveStocks >= 0)
                {
                    isChanged = true;
                    orderList[i] = new Order(currentTable, currentUser, saladsArray[i].Name, numericValue, saladsArray[i].Price);
                    saladsArray[i].Stocks = saladsArray[i].Stocks - numericValue;
                    dbHandler.UpdateProduct(TABLE_SALADS, saladsArray[i]);
                }
                else
                {
                    orderList[i] = null;
                }
            }
            dbHandler.CreateNewOrder(orderList);
            GetOrRefreshData(); //Refresh that data after updated

            return isChanged;
        }

        public void SetTableNumber(int tableNumber)
        {
            this.lblTableNumber.Text = tableNumber.ToString();
            this.currentTable = tableNumber;
        }

        public void SetCurrentMode(String currentMode)
        {
            this.currentMode = currentMode;

            if (currentMode.Equals(NEW_ORDER))
                this.lblMode.Text = "New Order Mode";

            else if (currentMode.Equals(UPDATE_ORDER))
                this.lblMode.Text = "Update Mode";
        }

        public bool UpdateOrder()
        {
            GetOrRefreshData(); //Refresh the data before update

            int numericValue;
            int positiveStocks = 0; //Check if the product stock number is positive
            bool isChanged = false; //Check if there is any changes (If the order include products)

            Order[] orderList = new Order[saladsArray.Length];

            for (int i = 0; i < saladsArray.Length; i++)
            {
                numericValue = Convert.ToInt32(numericUpDownArray[i].Value);
                if (numericValue != 0)
                {
                    isChanged = true;
                    orderList[i] = new Order(currentTable, "", saladsArray[i].Name, numericValue, saladsArray[i].Price);
                }
                else
                {
                    orderList[i] = null;
                }

                //Get the Correct Product Stock (Plus the "Before", Minus the "After")
                positiveStocks = saladsArray[i].Stocks + numericUpdateModeArray[i] - numericValue;
                if (positiveStocks >= 0)
                {
                    saladsArray[i].Stocks = positiveStocks;
                    dbHandler.UpdateProduct(TABLE_SALADS, saladsArray[i]); 
                }
                else
                {
                    MessageBox.Show("Failed. The Stocks are empty. Try Again.");
                    return false;
                }
            }

            dbHandler.CreateNewOrder(orderList); //Create New order
            GetOrRefreshData(); //Refresh the data after the update   

            return isChanged;
        }

        public void DeleteOrder()
        {
            dbHandler.DeleteOrder(currentTable);
        }

        public void SetCurrentUser(String user)
        {
            this.currentUser = user;
        }

        void MenuInterface.GetOrRefreshData()
        {
            throw new NotImplementedException();
        }

        void MenuInterface.SetNumericMaxValue()
        {
            throw new NotImplementedException();
        }
    }
}
