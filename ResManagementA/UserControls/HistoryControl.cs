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
using BrightIdeasSoftware; //For ObjectListView objects
using System.Globalization;

namespace ResManagement.UserControls
{
    public partial class HistoryControl : UserControl
    {
        private DBHandler dbHandler;
        private List<Order> ordersHistory;
        private readonly String ORDERS_LIST = "Orders List", PRODUCT_SALES = "Product Sales",
                                EMPLOYEE_SALES = "Employee Sales", TABLE_SALES = "Table Sales";

        public HistoryControl()
        {
            InitializeComponent();

            domainUpDown1.Items.Add(ORDERS_LIST);
            domainUpDown1.Items.Add(PRODUCT_SALES);
            domainUpDown1.Items.Add(EMPLOYEE_SALES);
            domainUpDown1.Items.Add(TABLE_SALES);

            dbHandler = new DBHandler();
            GetOrRefreshData();      
        }

        //Get the Data from DB 
        public void GetOrRefreshData()
        {
            //Clean The ListViews
            this.objectListView1.Items.Clear();
            this.objectListView2.Items.Clear();
            this.objectListView3.Items.Clear();
            this.objectListView4.Items.Clear();

            //Get The Orders List
            ordersHistory = dbHandler.GetOrdersHistory();

            //Add Orders List to ObjectListView
            objectListView1.SetObjects(ordersHistory);

            //listView2 - Contain Product Best Sales
            ordersHistory = dbHandler.GetOrdersCounting();
            objectListView2.SetObjects(ordersHistory);

            //listView3 - Contain Employee Top Sellers
            ordersHistory = dbHandler.GetEmployeeSales();
            objectListView3.SetObjects(ordersHistory);

            // listView4 - Contain Tables Sales
            ordersHistory = dbHandler.GetTableSales();
            objectListView4.SetObjects(ordersHistory);

            SetLabels();
        }

        //Change between the ListView's
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if(domainUpDown1.Text.Equals(ORDERS_LIST))
            {
                objectListView1.BringToFront();
                HeaderLbl.Text = ORDERS_LIST;
            }
            else if (domainUpDown1.Text.Equals(PRODUCT_SALES))
            {
                objectListView2.BringToFront();
                HeaderLbl.Text = PRODUCT_SALES;
            }
            else if (domainUpDown1.Text.Equals(EMPLOYEE_SALES))
            {
                objectListView3.BringToFront();
                HeaderLbl.Text = EMPLOYEE_SALES;
            }
            else if (domainUpDown1.Text.Equals(TABLE_SALES))
            {
                objectListView4.BringToFront();
                HeaderLbl.Text = TABLE_SALES;
            }
        }

        //Return Most Sold Product Name
        private String GetMostSold()
        {
            int max = 0;
            String mostSold = "";
            List<Order> list = dbHandler.GetOrdersCounting();

            foreach(Order order in list)
            {
                if (max < order.Quantity)
                {
                    max = order.Quantity;
                    mostSold = order.ProductName;
                }      
            }
            return mostSold +": "+ Convertor.ToKMB(max);
        }

        //Return Best Seller Name
        private String GetBestSeller()
        {
            int max = 0;
            String bestSeller = "";
            List<Order> list = dbHandler.GetEmployeeSales();

            foreach (Order order in list)
            {
                if (max < order.Price)
                {
                    max = order.Price;
                    bestSeller = order.Employee;
                }
            }
            return bestSeller.ToUpper() + ":" + Convertor.ToKMB(max) + " NIS";
        }

        //Return Total Sells and Quantity
        private void GetTotalSellsAndQuantity(out int totalSells, out int totalQuantity)
        {
            totalSells = 0;
            totalQuantity = 0;
            List<Order> list = dbHandler.GetEmployeeSales();

            foreach (Order order in list)
            {
                totalSells += order.Price;
                totalQuantity += order.Quantity;
            }
        }

        //Return Best Seller Name
        private String GetMostActiveTable()
        {
            int max = 0;
            int index = -1;
            List<Order> list = dbHandler.GetTableSales();

            foreach (Order order in list)
            {
                if (max < order.Price)
                {
                    max = order.Price;
                    index = list.IndexOf(order);
                }
            }
            index += 1;
            return index.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IncomeTxtChangeColor();
            timer1.Start();
        }

        //Set the Statistics Lables
        private void SetLabels()
        {
            mostSoldLbl.Text = GetMostSold();
            bestSellerLbl.Text = GetBestSeller();
            activeTableLbl.Text = GetMostActiveTable();

            int income, averageSell, totalQuantity;
            GetTotalSellsAndQuantity(out income, out totalQuantity);
            averageSell = income / totalQuantity;   
            avgOrderLbl.Text = Convertor.ToKMB(averageSell) + " NIS"; // Convert To K/M(miliion)
            totalIncomeLbl.Text = Convertor.ToKMB(income) + " NIS"; // or B(Billion)
        }

        //Method that change the Color of the "Income" Text
        private void IncomeTxtChangeColor()
        {
            if (totalIncomeLbl.ForeColor == Color.DarkGreen)
                totalIncomeLbl.ForeColor = Color.DarkOliveGreen;

            else if (totalIncomeLbl.ForeColor == Color.DarkOliveGreen)
                totalIncomeLbl.ForeColor = Color.Green;

            else if (totalIncomeLbl.ForeColor == Color.Green)
                totalIncomeLbl.ForeColor = Color.DarkKhaki;

            else if (totalIncomeLbl.ForeColor == Color.DarkKhaki)
                totalIncomeLbl.ForeColor = Color.GreenYellow;

            else if (totalIncomeLbl.ForeColor == Color.GreenYellow)
                totalIncomeLbl.ForeColor = Color.LawnGreen;

            else if (totalIncomeLbl.ForeColor == Color.LawnGreen)
                totalIncomeLbl.ForeColor = Color.LightGreen;

            else if (totalIncomeLbl.ForeColor == Color.LightGreen)
                totalIncomeLbl.ForeColor = Color.LightSeaGreen;

            else if (totalIncomeLbl.ForeColor == Color.LightSeaGreen)
                totalIncomeLbl.ForeColor = Color.DarkGreen;
        }
    }
}
