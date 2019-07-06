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
    public partial class BillForm : Form
    {
        private DBHandler dbHandler;
        private static ListViewItem listViewItem;
        private List<Order> orderList;
        private int currentTable = 0;
        private String currentUser;

        public BillForm(int currentTable,String user)
        {
            InitializeComponent();

            this.currentUser = user;
            this.currentTable = currentTable;
            dbHandler = new DBHandler();
            GetOrRefreshData();

            //Initial properties for PrintPreviewDialog screen
            printPreviewDialog1.Height = 1000;
            printPreviewDialog1.Width = 1000;
            printPreviewDialog1.FindForm().StartPosition = FormStartPosition.CenterScreen;
        }

        //Get the Data from DB 
        public void GetOrRefreshData()
        {
            int counter = 1;
            int sum = 0, total = 0;

            //Get the Users List
            orderList = dbHandler.GetOrdersList(currentTable);

            //Remove all items to clean the listView
            this.listView1.Items.Clear();

            //Build the listView and add Users details
            foreach (Order order in orderList)
            {
                listViewItem = new ListViewItem(Convert.ToString(counter++));
                listViewItem.SubItems.Add(order.ProductName);
                listViewItem.SubItems.Add(Convert.ToString(order.Quantity));
                listViewItem.SubItems.Add(Convert.ToString(order.Price));
                total = order.Price * order.Quantity;
                listViewItem.SubItems.Add(Convert.ToString(total) + " NIS");
                sum += total;
                listView1.Items.Add(listViewItem);
            }
            txtTotal.Text = Convert.ToString(sum) + " NIS";
            
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int total = 0;
            int sum = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.Equals(ProductNameTxt.Text))
                {
                    item.SubItems[2].Text = QuantityTxt.Text;
                    item.SubItems[3].Text = Pricetxt.Text;
                    total = Convert.ToInt32(Pricetxt.Text) * Convert.ToInt32(QuantityTxt.Text); 
                    item.SubItems[4].Text = Convert.ToString(total) +" NIS";
                }
                sum += Convert.ToInt32(item.SubItems[2].Text) * Convert.ToInt32(item.SubItems[3].Text);         
            }
            txtTotal.Text = Convert.ToString(sum) + " NIS";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Logo
            PictureBox picture = new PictureBox();
            picture.Image = pictureBox1.Image;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Width = 270;
            picture.Height = 150;
            picture.BackColor = Color.White;
            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            picture.DrawToBitmap(bitmap, new Rectangle(0, 0, picture.Width, picture.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap.Dispose();

            //Header
            e.Graphics.DrawString("LetEatB", new Font("Ariel", 36, FontStyle.Bold), Brushes.DarkRed, new Point(320, 100));
            e.Graphics.DrawString("Receipt", new Font("Ariel", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(370, 160));

            //Date and Time
            String Time = DateTime.Now.ToLongTimeString();
            String Date = DateTime.Now.ToLongDateString();
            e.Graphics.DrawString(Time, new Font("Ariel", 14, FontStyle.Bold), Brushes.Black, new Point(635, 60));
            e.Graphics.DrawString(Date, new Font("Ariel", 14, FontStyle.Bold), Brushes.Black, new Point(580,30));


            //Columns Names
            e.Graphics.DrawString("Product", new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(165, 205));
            e.Graphics.DrawString("Quantity", new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(380, 205));
            e.Graphics.DrawString("Price", new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(495, 205));
            e.Graphics.DrawString("Total", new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(615, 205));
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(130, 235), new Point(695, 235));

            int y = 15;
            foreach (ListViewItem item in listView1.Items)
            {
                e.Graphics.DrawString(item.SubItems[0].Text+".", new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(130, 220+y));
                e.Graphics.DrawString(item.SubItems[1].Text, new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(180, 220 + y));
                e.Graphics.DrawString(item.SubItems[2].Text, new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(410, 220 + y));
                e.Graphics.DrawString(item.SubItems[3].Text, new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(510, 220 + y));
                e.Graphics.DrawString(item.SubItems[4].Text, new Font("Ariel", 16, FontStyle.Bold), Brushes.Black, new Point(610, 220 + y));
                y += 30;
            }
            e.Graphics.DrawString("Total: "+txtTotal.Text, new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(330, 240+y));
            e.Graphics.DrawString("Thank You!", new Font("Ariel", 22, FontStyle.Bold), Brushes.DarkRed, new Point(323, 270 + y));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;

            ProductNameTxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
            QuantityTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            Pricetxt.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        //KeyPress handler for PhoneNumber and Age fields
        private void KeyPressNumbersOnly(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            //Permitted chars will be BackSpace<- or Digits only
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

       
    }
}
