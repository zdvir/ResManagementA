using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ResManagement.Classes;

namespace ResManagement.UserControls
{
    public partial class InventoryControl : UserControl
    {  
        private String TABLE_BURGERS = "BurgersTable";
        private String TABLE_SALADS = "SaladsTable";
        private String TABLE_BEVERAGES = "BeveragesTable";
        private String TABLE_SIDES = "SidesTable";

        private Product[] burgersArray, saladsArray, beveragesArray, sidesArray;
        private Panel[] panelsArray;

        private List<RadioButton> rbArray, rbArrayPart0, rbArrayPart1, rbArrayPart2, rbArrayPart3;
        private List<TextBox> tbArray0, tbArray1, tbArray2, tbArray3 ,tbAll;
        private List<Label> lblArray0, lblArray1, lblArray2, lblArray3;

        private DBHandler dbHandler = new DBHandler();
        private String imageLocation = null;
        private static RadioButton currentRB;

        private String currentUser;

        public InventoryControl()
        {
            InitializeComponent();

            panelsArray = new Panel[] {panel1,panel2,panel3,panel4}; 
            
            //Get al the Radio Buttons into One array
            rbArrayPart0 = panelsArray[0].Controls.OfType<RadioButton>().ToList();
            rbArrayPart1 = panelsArray[1].Controls.OfType<RadioButton>().ToList();
            rbArrayPart2 = panelsArray[2].Controls.OfType<RadioButton>().ToList();
            rbArrayPart3 = panelsArray[3].Controls.OfType<RadioButton>().ToList();

            //Get al the TextBox's into One array
            tbArray0 = panelsArray[0].Controls.OfType<TextBox>().ToList();
            tbArray1 = panelsArray[1].Controls.OfType<TextBox>().ToList();
            tbArray2 = panelsArray[2].Controls.OfType<TextBox>().ToList();
            tbArray3 = panelsArray[3].Controls.OfType<TextBox>().ToList();
            tbAll = tbArray0.Concat(tbArray1).Concat(tbArray2).Concat(tbArray3).ToList<TextBox>();

            //Get al the Labels into One array
            lblArray0 = panelsArray[0].Controls.OfType<Label>().ToList();
            lblArray1 = panelsArray[1].Controls.OfType<Label>().ToList();
            lblArray2 = panelsArray[2].Controls.OfType<Label>().ToList();
            lblArray3 = panelsArray[3].Controls.OfType<Label>().ToList();

            //Reverse all Lists so their index number will be equal to the Object sequence number
            rbArrayPart0.Reverse();
            rbArrayPart1.Reverse();
            rbArrayPart2.Reverse();
            rbArrayPart3.Reverse();
            
            tbArray0.Reverse();
            tbArray1.Reverse();
            tbArray2.Reverse();
            tbArray3.Reverse();

            lblArray0.Reverse();
            lblArray1.Reverse();
            lblArray2.Reverse();
            lblArray3.Reverse();

            //Get the Data from DB to the controls
            GetOrRefreshData(); 
        }

        private void ButtonsEnabled(bool x)
        {
            foreach (TextBox t in tbAll)
                t.Enabled = x;

            SaveBtn1.Enabled = x;
            SaveBtn2.Enabled = x;
            SaveBtn3.Enabled = x;
            SaveBtn4.Enabled = x;

            BrowseBtn1.Enabled = x;
            BrowseBtn2.Enabled = x;
            BrowseBtn3.Enabled = x;
            BrowseBtn4.Enabled = x;
        }
        //Get the Data from DB to the controls
        public void GetOrRefreshData()
        {
            //Merge all the partial Radio Button Arrays to One array
            rbArray = rbArrayPart0.Concat(rbArrayPart1).Concat(rbArrayPart2).Concat(rbArrayPart3).ToList();

            //Get all the Products into Array's
            burgersArray = dbHandler.GetProductList(TABLE_BURGERS).ToArray();
            saladsArray = dbHandler.GetProductList(TABLE_SALADS).ToArray();
            beveragesArray = dbHandler.GetProductList(TABLE_BEVERAGES).ToArray();
            sidesArray = dbHandler.GetProductList(TABLE_SIDES).ToArray();

            //Enter products details to the TextBox fields
            for (int i = 0, j = 0; i < burgersArray.Length; i++, j = j + 2)
            {
                tbArray0[j].Text = burgersArray[i].Price.ToString();
                tbArray0[j + 1].Text = burgersArray[i].Stocks.ToString();
                lblArray0[i].Text = burgersArray[i].Name;
            }

            for (int i = 0, j = 0; i < saladsArray.Length; i++, j = j + 2)
            {
                tbArray1[j].Text = saladsArray[i].Price.ToString();
                tbArray1[j + 1].Text = saladsArray[i].Stocks.ToString();
                lblArray1[i].Text = saladsArray[i].Name;
            }

            for (int i = 0, j = 0; i < beveragesArray.Length; i++, j = j + 2)
            {
                tbArray2[j].Text = beveragesArray[i].Price.ToString();
                tbArray2[j + 1].Text = beveragesArray[i].Stocks.ToString();
                lblArray2[i].Text = beveragesArray[i].Name;
            }

            for (int i = 0, j = 0; i < sidesArray.Length; i++, j = j + 2)
            {
                tbArray3[j].Text = sidesArray[i].Price.ToString();
                tbArray3[j + 1].Text = sidesArray[i].Stocks.ToString();
                lblArray3[i].Text = sidesArray[i].Name;
            }
        }

        //Browse Button in panel1 Clicked
        private void BrowseBtn1_Click(object sender, EventArgs e)
        {
            if (rbArrayPart0.Contains(currentRB))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBox1.ImageLocation = imageLocation;

                    int x = rbArrayPart0.IndexOf(currentRB);
                    byte[] image = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);
                    burgersArray[x].Image = image; 
                }
            }
            else
                MessageBox.Show("Choose Product");
        }

        //Browse Button in panel2 Clicked
        private void BrowseBtn2_Click(object sender, EventArgs e)
        {
            if (rbArrayPart1.Contains(currentRB))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBox2.ImageLocation = imageLocation;

                    int x = rbArrayPart1.IndexOf(currentRB);
                    byte[] image = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);
                    saladsArray[x].Image = image;
                }
            }
            else
                MessageBox.Show("Choose Product");
        }

        //Browse Button in panel3 Clicked
        private void BrowseBtn3_Click(object sender, EventArgs e)
        {
            if (rbArrayPart2.Contains(currentRB))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBox3.ImageLocation = imageLocation;

                    int x = rbArrayPart2.IndexOf(currentRB);
                    byte[] image = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);
                    beveragesArray[x].Image = image;
                }
            }
            else
                MessageBox.Show("Choose Product");
        }

        //Browse Button in panel4 Clicked
        private void BrowseBtn4_Click(object sender, EventArgs e)
        {
            if (rbArrayPart3.Contains(currentRB))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBox4.ImageLocation = imageLocation;

                    int x = rbArrayPart3.IndexOf(currentRB);
                    byte[] image = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);
                    sidesArray[x].Image = image;
                }
            }
            else
                MessageBox.Show("Choose Product");
        }

        //Save Button in panel1 Clicked
        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            int x=0;
            for (int i = 0, j = 0; i < burgersArray.Length; i++, j = j + 2)
            {
                burgersArray[i].Price = Int32.Parse(tbArray0[j].Text);
                burgersArray[i].Stocks = Int32.Parse(tbArray0[j + 1].Text);

                x = dbHandler.UpdateProduct(TABLE_BURGERS, burgersArray[i]);
            }
            if(x==1)
                MessageBox.Show("Saved Successfuly");           
        }

        //Save Button in panel2 Clicked
        private void SaveBtn2_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0, j = 0; i < saladsArray.Length; i++, j = j + 2)
            {
                saladsArray[i].Price = Int32.Parse(tbArray1[j].Text);
                saladsArray[i].Stocks = Int32.Parse(tbArray1[j + 1].Text);

                x = dbHandler.UpdateProduct(TABLE_SALADS, saladsArray[i]);
            }
            if (x == 1)
                MessageBox.Show("Saved Successfuly");
        }

        //Save Button in panel3 Clicked
        private void SaveBtn3_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0, j = 0; i < beveragesArray.Length; i++, j = j + 2)
            {
                beveragesArray[i].Price = Int32.Parse(tbArray2[j].Text);
                beveragesArray[i].Stocks = Int32.Parse(tbArray2[j + 1].Text);

                x = dbHandler.UpdateProduct(TABLE_BEVERAGES, beveragesArray[i]);
            }
            if (x == 1)
                MessageBox.Show("Saved Successfuly");
        }

        //Save Button in panel4 Clicked
        private void SaveBtn4_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0, j = 0; i < sidesArray.Length; i++, j = j + 2)
            {
                sidesArray[i].Price = Int32.Parse(tbArray3[j].Text);
                sidesArray[i].Stocks = Int32.Parse(tbArray3[j + 1].Text);

                x = dbHandler.UpdateProduct(TABLE_SIDES, sidesArray[i]);
            }
            if (x == 1)
                MessageBox.Show("Saved Successfuly");
        }

        //When Radio Button Clicked - Show the Picture of the specific Product
        private void RadioButton_Click(object sender, EventArgs e)
        {
            int indexOfRB =0;
            currentRB = (RadioButton)sender;

            if (rbArrayPart0.Contains(currentRB))
            {
                indexOfRB = rbArrayPart0.IndexOf(currentRB);
                MemoryStream ms = new MemoryStream(burgersArray[indexOfRB].Image);
                pictureBox1.Image = Image.FromStream(ms);
            }

            if (rbArrayPart1.Contains(currentRB))
            {
                indexOfRB = rbArrayPart1.IndexOf(currentRB);
                MemoryStream ms = new MemoryStream(saladsArray[indexOfRB].Image);
                pictureBox2.Image = Image.FromStream(ms);
            }

            if (rbArrayPart2.Contains(currentRB))
            {
                indexOfRB = rbArrayPart2.IndexOf(currentRB);
                MemoryStream ms = new MemoryStream(beveragesArray[indexOfRB].Image);
                pictureBox3.Image = Image.FromStream(ms);
            }

            if (rbArrayPart3.Contains(currentRB))
            {
                indexOfRB = rbArrayPart3.IndexOf(currentRB);
                MemoryStream ms = new MemoryStream(sidesArray[indexOfRB].Image);
                pictureBox4.Image = Image.FromStream(ms);
            }

        }

        public void SetCurrentUser(String user)
        {
            this.currentUser = user;

            if (dbHandler.IsAdmin(currentUser))
                ButtonsEnabled(true);
            else
                ButtonsEnabled(false);
        }
    }
}
