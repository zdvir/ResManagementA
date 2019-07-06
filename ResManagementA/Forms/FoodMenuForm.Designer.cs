namespace ResManagement.Forms
{
    partial class FoodMenuForm
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
            this.BurgersBtn = new System.Windows.Forms.Button();
            this.SaladsBtn = new System.Windows.Forms.Button();
            this.SidesBtn = new System.Windows.Forms.Button();
            this.BeveragesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.beveragesMenuControl1 = new ResManagement.UserControls.BeveragesMenuControl();
            this.sidesMenuControl1 = new ResManagement.UserControls.SidesMenuControl();
            this.saladsMenuControl1 = new ResManagement.UserControls.SaladsMenuControl();
            this.burgersMenuControl1 = new ResManagement.UserControls.BurgersMenuControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BurgersBtn
            // 
            this.BurgersBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BurgersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BurgersBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BurgersBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BurgersBtn.Location = new System.Drawing.Point(0, 0);
            this.BurgersBtn.Name = "BurgersBtn";
            this.BurgersBtn.Size = new System.Drawing.Size(251, 100);
            this.BurgersBtn.TabIndex = 3;
            this.BurgersBtn.Text = "Burgers";
            this.BurgersBtn.UseVisualStyleBackColor = false;
            this.BurgersBtn.Click += new System.EventHandler(this.BurgersBtn_Click);
            // 
            // SaladsBtn
            // 
            this.SaladsBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaladsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaladsBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SaladsBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SaladsBtn.Location = new System.Drawing.Point(250, 0);
            this.SaladsBtn.Name = "SaladsBtn";
            this.SaladsBtn.Size = new System.Drawing.Size(258, 100);
            this.SaladsBtn.TabIndex = 2;
            this.SaladsBtn.Text = "Salads / Veggies";
            this.SaladsBtn.UseVisualStyleBackColor = false;
            this.SaladsBtn.Click += new System.EventHandler(this.SaladsBtn_Click);
            // 
            // SidesBtn
            // 
            this.SidesBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SidesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidesBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SidesBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SidesBtn.Location = new System.Drawing.Point(759, 0);
            this.SidesBtn.Name = "SidesBtn";
            this.SidesBtn.Size = new System.Drawing.Size(259, 100);
            this.SidesBtn.TabIndex = 1;
            this.SidesBtn.Text = "Sides";
            this.SidesBtn.UseVisualStyleBackColor = false;
            this.SidesBtn.Click += new System.EventHandler(this.SidesBtn_Click);
            // 
            // BeveragesBtn
            // 
            this.BeveragesBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.BeveragesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeveragesBtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BeveragesBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BeveragesBtn.Location = new System.Drawing.Point(507, 0);
            this.BeveragesBtn.Name = "BeveragesBtn";
            this.BeveragesBtn.Size = new System.Drawing.Size(254, 100);
            this.BeveragesBtn.TabIndex = 2;
            this.BeveragesBtn.Text = "Beverages";
            this.BeveragesBtn.UseVisualStyleBackColor = false;
            this.BeveragesBtn.Click += new System.EventHandler(this.BeveragesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.BurgersBtn);
            this.panel1.Controls.Add(this.SaladsBtn);
            this.panel1.Controls.Add(this.BeveragesBtn);
            this.panel1.Controls.Add(this.SidesBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 100);
            this.panel1.TabIndex = 30;
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FinishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FinishBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FinishBtn.Location = new System.Drawing.Point(531, 484);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(150, 40);
            this.FinishBtn.TabIndex = 61;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Red;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ClearBtn.Location = new System.Drawing.Point(316, 484);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(150, 40);
            this.ClearBtn.TabIndex = 62;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // beveragesMenuControl1
            // 
            this.beveragesMenuControl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.beveragesMenuControl1.Location = new System.Drawing.Point(0, 96);
            this.beveragesMenuControl1.Name = "beveragesMenuControl1";
            this.beveragesMenuControl1.Size = new System.Drawing.Size(1004, 361);
            this.beveragesMenuControl1.TabIndex = 65;
            // 
            // sidesMenuControl1
            // 
            this.sidesMenuControl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sidesMenuControl1.Location = new System.Drawing.Point(0, 96);
            this.sidesMenuControl1.Name = "sidesMenuControl1";
            this.sidesMenuControl1.Size = new System.Drawing.Size(1004, 361);
            this.sidesMenuControl1.TabIndex = 66;
            // 
            // saladsMenuControl1
            // 
            this.saladsMenuControl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.saladsMenuControl1.Location = new System.Drawing.Point(0, 96);
            this.saladsMenuControl1.Name = "saladsMenuControl1";
            this.saladsMenuControl1.Size = new System.Drawing.Size(1004, 361);
            this.saladsMenuControl1.TabIndex = 67;
            // 
            // burgersMenuControl1
            // 
            this.burgersMenuControl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.burgersMenuControl1.Location = new System.Drawing.Point(0, 96);
            this.burgersMenuControl1.Name = "burgersMenuControl1";
            this.burgersMenuControl1.Size = new System.Drawing.Size(1004, 361);
            this.burgersMenuControl1.TabIndex = 68;
            // 
            // FoodMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.burgersMenuControl1);
            this.Controls.Add(this.saladsMenuControl1);
            this.Controls.Add(this.sidesMenuControl1);
            this.Controls.Add(this.beveragesMenuControl1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FoodMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodMenuForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BurgersBtn;
        private System.Windows.Forms.Button SaladsBtn;
        private System.Windows.Forms.Button SidesBtn;
        private System.Windows.Forms.Button BeveragesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button ClearBtn;
        private UserControls.BeveragesMenuControl beveragesMenuControl1;
        private UserControls.SidesMenuControl sidesMenuControl1;
        private UserControls.SaladsMenuControl saladsMenuControl1;
        private UserControls.BurgersMenuControl burgersMenuControl1;
    }
}