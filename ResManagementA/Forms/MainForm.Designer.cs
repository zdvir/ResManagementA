namespace ResManagement.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.UserLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ViewHistoryBtn = new System.Windows.Forms.Button();
            this.ViewTableBtn = new System.Windows.Forms.Button();
            this.InventoryBtn = new System.Windows.Forms.Button();
            this.ViewProfilesBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.viewTableControl1 = new ResManagement.UserControls.ViewTableControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.homeControl1 = new ResManagement.UserControls.HomeControl();
            this.historyControl1 = new ResManagement.UserControls.HistoryControl();
            this.inventoryControl1 = new ResManagement.UserControls.InventoryControl();
            this.viewProfilesControl1 = new ResManagement.UserControls.ViewProfilesControl();
            this.registerControl1 = new ResManagement.UserControls.RegisterControl();
            this.viewTableControl2 = new ResManagement.UserControls.ViewTableControl();
            this.settingsControl1 = new ResManagement.UserControls.SettingsControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.UserLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.ViewHistoryBtn);
            this.panel1.Controls.Add(this.ViewTableBtn);
            this.panel1.Controls.Add(this.InventoryBtn);
            this.panel1.Controls.Add(this.ViewProfilesBtn);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 650);
            this.panel1.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogOutBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.Location = new System.Drawing.Point(61, 568);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(65, 52);
            this.LogOutBtn.TabIndex = 7;
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UserLbl.ForeColor = System.Drawing.Color.Red;
            this.UserLbl.Location = new System.Drawing.Point(0, 61);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(197, 37);
            this.UserLbl.TabIndex = 10;
            this.UserLbl.Text = "USER";
            this.UserLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 125);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 60);
            this.SidePanel.TabIndex = 3;
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(0, 125);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(200, 60);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ViewHistoryBtn
            // 
            this.ViewHistoryBtn.FlatAppearance.BorderSize = 0;
            this.ViewHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewHistoryBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ViewHistoryBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewHistoryBtn.Location = new System.Drawing.Point(0, 407);
            this.ViewHistoryBtn.Name = "ViewHistoryBtn";
            this.ViewHistoryBtn.Size = new System.Drawing.Size(200, 63);
            this.ViewHistoryBtn.TabIndex = 4;
            this.ViewHistoryBtn.Text = "Orders";
            this.ViewHistoryBtn.UseVisualStyleBackColor = true;
            this.ViewHistoryBtn.Click += new System.EventHandler(this.ViewHistoryBtn_Click);
            // 
            // ViewTableBtn
            // 
            this.ViewTableBtn.FlatAppearance.BorderSize = 0;
            this.ViewTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTableBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ViewTableBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewTableBtn.Location = new System.Drawing.Point(0, 183);
            this.ViewTableBtn.Name = "ViewTableBtn";
            this.ViewTableBtn.Size = new System.Drawing.Size(200, 71);
            this.ViewTableBtn.TabIndex = 0;
            this.ViewTableBtn.Text = "View Tables";
            this.ViewTableBtn.UseVisualStyleBackColor = true;
            this.ViewTableBtn.Click += new System.EventHandler(this.ViewTableBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.FlatAppearance.BorderSize = 0;
            this.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InventoryBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.InventoryBtn.Location = new System.Drawing.Point(12, 252);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(188, 72);
            this.InventoryBtn.TabIndex = 1;
            this.InventoryBtn.Text = "Inventory / Prices";
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // ViewProfilesBtn
            // 
            this.ViewProfilesBtn.FlatAppearance.BorderSize = 0;
            this.ViewProfilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProfilesBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ViewProfilesBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewProfilesBtn.Location = new System.Drawing.Point(0, 330);
            this.ViewProfilesBtn.Name = "ViewProfilesBtn";
            this.ViewProfilesBtn.Size = new System.Drawing.Size(200, 71);
            this.ViewProfilesBtn.TabIndex = 3;
            this.ViewProfilesBtn.Text = "Profiles";
            this.ViewProfilesBtn.UseVisualStyleBackColor = true;
            this.ViewProfilesBtn.Click += new System.EventHandler(this.ViewProfilesBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.RegisterBtn.Location = new System.Drawing.Point(0, 476);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(200, 70);
            this.RegisterBtn.TabIndex = 2;
            this.RegisterBtn.Text = "Register User";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.Datelbl);
            this.panel2.Controls.Add(this.Timelbl);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.SettingsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 55);
            this.panel2.TabIndex = 1;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(20, 9);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(76, 31);
            this.Datelbl.TabIndex = 8;
            this.Datelbl.Text = "Date";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Timelbl.ForeColor = System.Drawing.Color.White;
            this.Timelbl.Location = new System.Drawing.Point(331, 9);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(78, 31);
            this.Timelbl.TabIndex = 7;
            this.Timelbl.Text = "Time";
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(959, -2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(58, 57);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.Location = new System.Drawing.Point(891, 2);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(52, 49);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // viewTableControl1
            // 
            this.viewTableControl1.BackColor = System.Drawing.SystemColors.Window;
            this.viewTableControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewTableControl1.BackgroundImage")));
            this.viewTableControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewTableControl1.Location = new System.Drawing.Point(199, 191);
            this.viewTableControl1.Name = "viewTableControl1";
            this.viewTableControl1.Size = new System.Drawing.Size(1021, 459);
            this.viewTableControl1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.SystemColors.Window;
            this.homeControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeControl1.BackgroundImage")));
            this.homeControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeControl1.Location = new System.Drawing.Point(201, 52);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1020, 598);
            this.homeControl1.TabIndex = 44;
            // 
            // historyControl1
            // 
            this.historyControl1.BackColor = System.Drawing.Color.Azure;
            this.historyControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyControl1.BackgroundImage")));
            this.historyControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyControl1.Location = new System.Drawing.Point(201, 52);
            this.historyControl1.Name = "historyControl1";
            this.historyControl1.Size = new System.Drawing.Size(1020, 598);
            this.historyControl1.TabIndex = 45;
            // 
            // inventoryControl1
            // 
            this.inventoryControl1.BackColor = System.Drawing.Color.Transparent;
            this.inventoryControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventoryControl1.BackgroundImage")));
            this.inventoryControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryControl1.Location = new System.Drawing.Point(201, 52);
            this.inventoryControl1.Name = "inventoryControl1";
            this.inventoryControl1.Size = new System.Drawing.Size(1020, 598);
            this.inventoryControl1.TabIndex = 46;
            // 
            // viewProfilesControl1
            // 
            this.viewProfilesControl1.BackColor = System.Drawing.Color.Transparent;
            this.viewProfilesControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewProfilesControl1.BackgroundImage")));
            this.viewProfilesControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewProfilesControl1.Location = new System.Drawing.Point(201, 52);
            this.viewProfilesControl1.Name = "viewProfilesControl1";
            this.viewProfilesControl1.Size = new System.Drawing.Size(1019, 597);
            this.viewProfilesControl1.TabIndex = 47;
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerControl1.BackgroundImage")));
            this.registerControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerControl1.Location = new System.Drawing.Point(201, 52);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(1019, 598);
            this.registerControl1.TabIndex = 48;
            // 
            // viewTableControl2
            // 
            this.viewTableControl2.BackColor = System.Drawing.Color.White;
            this.viewTableControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewTableControl2.BackgroundImage")));
            this.viewTableControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewTableControl2.Location = new System.Drawing.Point(201, 52);
            this.viewTableControl2.Name = "viewTableControl2";
            this.viewTableControl2.Size = new System.Drawing.Size(1020, 598);
            this.viewTableControl2.TabIndex = 49;
            // 
            // settingsControl1
            // 
            this.settingsControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsControl1.BackgroundImage")));
            this.settingsControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsControl1.Location = new System.Drawing.Point(201, 52);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(1020, 598);
            this.settingsControl1.TabIndex = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 650);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.viewTableControl2);
            this.Controls.Add(this.registerControl1);
            this.Controls.Add(this.viewProfilesControl1);
            this.Controls.Add(this.inventoryControl1);
            this.Controls.Add(this.historyControl1);
            this.Controls.Add(this.settingsControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1220, 650);
            this.MinimumSize = new System.Drawing.Size(1220, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewHistoryBtn;
        private System.Windows.Forms.Button ViewProfilesBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button InventoryBtn;
        private System.Windows.Forms.Button ViewTableBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBtn;
        private UserControls.ViewTableControl viewTableControl1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Timer timer1;
        private UserControls.HomeControl homeControl1;
        private UserControls.HistoryControl historyControl1;
        private UserControls.InventoryControl inventoryControl1;
        private UserControls.ViewProfilesControl viewProfilesControl1;
        private UserControls.RegisterControl registerControl1;
        private UserControls.ViewTableControl viewTableControl2;
        private UserControls.SettingsControl settingsControl1;
    }
}