namespace ResManagement.UserControls
{
    partial class HistoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryControl));
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.objectListView2 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeTableLbl = new System.Windows.Forms.Label();
            this.bestSellerLbl = new System.Windows.Forms.Label();
            this.mostSoldLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalIncomeLbl = new System.Windows.Forms.Label();
            this.avgOrderLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.objectListView3 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListView4 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLbl.Font = new System.Drawing.Font("", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLbl.Location = new System.Drawing.Point(273, 120);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(719, 63);
            this.HeaderLbl.TabIndex = 37;
            this.HeaderLbl.Text = "Orders List";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.AllColumns.Add(this.olvColumn5);
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.objectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(273, 186);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(719, 381);
            this.objectListView1.TabIndex = 39;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "TableID";
            this.olvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Text = "TableID";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Width = 82;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Employee";
            this.olvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Text = "Employee";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Width = 221;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "ProductName";
            this.olvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.Text = "Product";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.Width = 205;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Quantity";
            this.olvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.Text = "Quantity";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.Width = 99;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Price";
            this.olvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn5.Text = "Price";
            this.olvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn5.Width = 89;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.domainUpDown1.Location = new System.Drawing.Point(70, 186);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(143, 29);
            this.domainUpDown1.TabIndex = 40;
            this.domainUpDown1.Text = "Orders List";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // objectListView2
            // 
            this.objectListView2.AllColumns.Add(this.olvColumn8);
            this.objectListView2.AllColumns.Add(this.olvColumn9);
            this.objectListView2.AllColumns.Add(this.olvColumn10);
            this.objectListView2.AllColumns.Add(this.olvColumn11);
            this.objectListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn8,
            this.olvColumn9,
            this.olvColumn10,
            this.olvColumn11});
            this.objectListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.objectListView2.GridLines = true;
            this.objectListView2.Location = new System.Drawing.Point(273, 186);
            this.objectListView2.Name = "objectListView2";
            this.objectListView2.ShowGroups = false;
            this.objectListView2.Size = new System.Drawing.Size(719, 381);
            this.objectListView2.TabIndex = 41;
            this.objectListView2.UseCompatibleStateImageBehavior = false;
            this.objectListView2.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "ProductName";
            this.olvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn8.Text = "Product";
            this.olvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn8.Width = 205;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Quantity";
            this.olvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn9.Text = "Quantity";
            this.olvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn9.Width = 99;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "Price";
            this.olvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn10.Text = "Price";
            this.olvColumn10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn10.Width = 89;
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "TableID";
            this.olvColumn11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn11.Text = "Sales";
            this.olvColumn11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(98, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Statistics";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.activeTableLbl);
            this.panel1.Controls.Add(this.bestSellerLbl);
            this.panel1.Controls.Add(this.mostSoldLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 139);
            this.panel1.TabIndex = 43;
            // 
            // activeTableLbl
            // 
            this.activeTableLbl.BackColor = System.Drawing.Color.Transparent;
            this.activeTableLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.activeTableLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.activeTableLbl.Location = new System.Drawing.Point(-1, 114);
            this.activeTableLbl.Name = "activeTableLbl";
            this.activeTableLbl.Size = new System.Drawing.Size(228, 19);
            this.activeTableLbl.TabIndex = 50;
            this.activeTableLbl.Text = "Product";
            this.activeTableLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bestSellerLbl
            // 
            this.bestSellerLbl.BackColor = System.Drawing.Color.Transparent;
            this.bestSellerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bestSellerLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bestSellerLbl.Location = new System.Drawing.Point(-1, 68);
            this.bestSellerLbl.Name = "bestSellerLbl";
            this.bestSellerLbl.Size = new System.Drawing.Size(228, 19);
            this.bestSellerLbl.TabIndex = 49;
            this.bestSellerLbl.Text = "Product";
            this.bestSellerLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mostSoldLbl
            // 
            this.mostSoldLbl.BackColor = System.Drawing.Color.Transparent;
            this.mostSoldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mostSoldLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mostSoldLbl.Location = new System.Drawing.Point(-1, 29);
            this.mostSoldLbl.Name = "mostSoldLbl";
            this.mostSoldLbl.Size = new System.Drawing.Size(228, 19);
            this.mostSoldLbl.TabIndex = 48;
            this.mostSoldLbl.Text = "Product";
            this.mostSoldLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(-1, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Most Active Table";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(-1, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Best Seller";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(-1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Most Sold";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalIncomeLbl);
            this.panel2.Controls.Add(this.avgOrderLbl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(28, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 139);
            this.panel2.TabIndex = 49;
            // 
            // totalIncomeLbl
            // 
            this.totalIncomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.totalIncomeLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.totalIncomeLbl.Location = new System.Drawing.Point(-1, 92);
            this.totalIncomeLbl.Name = "totalIncomeLbl";
            this.totalIncomeLbl.Size = new System.Drawing.Size(228, 31);
            this.totalIncomeLbl.TabIndex = 52;
            this.totalIncomeLbl.Text = "123132123";
            this.totalIncomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgOrderLbl
            // 
            this.avgOrderLbl.BackColor = System.Drawing.Color.Transparent;
            this.avgOrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.avgOrderLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.avgOrderLbl.Location = new System.Drawing.Point(-1, 40);
            this.avgOrderLbl.Name = "avgOrderLbl";
            this.avgOrderLbl.Size = new System.Drawing.Size(227, 19);
            this.avgOrderLbl.TabIndex = 51;
            this.avgOrderLbl.Text = "123123";
            this.avgOrderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(-1, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 27);
            this.label7.TabIndex = 48;
            this.label7.Text = "Average Product Cost:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(-1, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 27);
            this.label10.TabIndex = 46;
            this.label10.Text = "Total Income";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objectListView3
            // 
            this.objectListView3.AllColumns.Add(this.olvColumn7);
            this.objectListView3.AllColumns.Add(this.olvColumn12);
            this.objectListView3.AllColumns.Add(this.olvColumn13);
            this.objectListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn12,
            this.olvColumn13});
            this.objectListView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.objectListView3.GridLines = true;
            this.objectListView3.Location = new System.Drawing.Point(273, 186);
            this.objectListView3.Name = "objectListView3";
            this.objectListView3.ShowGroups = false;
            this.objectListView3.Size = new System.Drawing.Size(719, 381);
            this.objectListView3.TabIndex = 50;
            this.objectListView3.UseCompatibleStateImageBehavior = false;
            this.objectListView3.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Employee";
            this.olvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn7.Text = "Employee";
            this.olvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn7.Width = 221;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "Quantity";
            this.olvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn12.Text = "Quantity";
            this.olvColumn12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn12.Width = 99;
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Price";
            this.olvColumn13.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn13.Text = "Sales";
            this.olvColumn13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn13.Width = 89;
            // 
            // objectListView4
            // 
            this.objectListView4.AllColumns.Add(this.olvColumn6);
            this.objectListView4.AllColumns.Add(this.olvColumn15);
            this.objectListView4.AllColumns.Add(this.olvColumn16);
            this.objectListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6,
            this.olvColumn15,
            this.olvColumn16});
            this.objectListView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.objectListView4.GridLines = true;
            this.objectListView4.Location = new System.Drawing.Point(273, 186);
            this.objectListView4.Name = "objectListView4";
            this.objectListView4.ShowGroups = false;
            this.objectListView4.Size = new System.Drawing.Size(719, 381);
            this.objectListView4.TabIndex = 51;
            this.objectListView4.UseCompatibleStateImageBehavior = false;
            this.objectListView4.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "TableID";
            this.olvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn6.Text = "TableID";
            this.olvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn6.Width = 84;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "Quantity";
            this.olvColumn15.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn15.Text = "Quantity";
            this.olvColumn15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn15.Width = 124;
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "Price";
            this.olvColumn16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn16.Text = "Sales";
            this.olvColumn16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn16.Width = 217;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.objectListView2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.HeaderLbl);
            this.Controls.Add(this.objectListView3);
            this.Controls.Add(this.objectListView4);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(1020, 598);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeaderLbl;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private BrightIdeasSoftware.ObjectListView objectListView2;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label activeTableLbl;
        private System.Windows.Forms.Label bestSellerLbl;
        private System.Windows.Forms.Label mostSoldLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalIncomeLbl;
        private System.Windows.Forms.Label avgOrderLbl;
        private BrightIdeasSoftware.ObjectListView objectListView3;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.ObjectListView objectListView4;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
