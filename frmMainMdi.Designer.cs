namespace FlowerShop
{
    partial class frmMainMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMdi));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_FoodCategu = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_FoodUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_FoodDef = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_InsertFood = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_CustomerDef = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_Factor = new System.Windows.Forms.ToolStripMenuItem();
            this.chpFactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Security = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecurity_DefineUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Help_Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File,
            this.Mnu_Security,
            this.Mnu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Mnu_File
            // 
            this.Mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File_FoodCategu,
            this.Mnu_File_FoodUnit,
            this.toolStripMenuItem5,
            this.Mnu_File_FoodDef,
            this.Mnu_File_InsertFood,
            this.toolStripMenuItem3,
            this.Mnu_File_CustomerDef,
            this.toolStripMenuItem4,
            this.Mnu_File_Factor,
            this.chpFactorToolStripMenuItem,
            this.toolStripMenuItem6,
            this.Mnu_File_Exit});
            this.Mnu_File.Image = global::FlowerShop.Properties.Resources.File_MnuIco;
            this.Mnu_File.Name = "Mnu_File";
            this.Mnu_File.Size = new System.Drawing.Size(148, 36);
            this.Mnu_File.Text = "منوی پرونده     |";
            // 
            // Mnu_File_FoodCategu
            // 
            this.Mnu_File_FoodCategu.Image = global::FlowerShop.Properties.Resources.FoodUnit_Ico;
            this.Mnu_File_FoodCategu.Name = "Mnu_File_FoodCategu";
            this.Mnu_File_FoodCategu.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_FoodCategu.Text = "دسته بندی";
            this.Mnu_File_FoodCategu.Click += new System.EventHandler(this.Mnu_File_FoodCategu_Click);
            // 
            // Mnu_File_FoodUnit
            // 
            this.Mnu_File_FoodUnit.Image = global::FlowerShop.Properties.Resources.Unit_2Icon;
            this.Mnu_File_FoodUnit.Name = "Mnu_File_FoodUnit";
            this.Mnu_File_FoodUnit.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_FoodUnit.Text = "واحد شمارش";
            this.Mnu_File_FoodUnit.Click += new System.EventHandler(this.Mnu_File_FoodUnit_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(172, 6);
            // 
            // Mnu_File_FoodDef
            // 
            this.Mnu_File_FoodDef.Image = global::FlowerShop.Properties.Resources.New_Folder;
            this.Mnu_File_FoodDef.Name = "Mnu_File_FoodDef";
            this.Mnu_File_FoodDef.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_FoodDef.Text = "ثبت عنوان گلها";
            this.Mnu_File_FoodDef.Click += new System.EventHandler(this.Mnu_File_FoodDef_Click);
            // 
            // Mnu_File_InsertFood
            // 
            this.Mnu_File_InsertFood.Image = global::FlowerShop.Properties.Resources.box;
            this.Mnu_File_InsertFood.Name = "Mnu_File_InsertFood";
            this.Mnu_File_InsertFood.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_InsertFood.Text = "ثبت ورود گل";
            this.Mnu_File_InsertFood.Click += new System.EventHandler(this.Mnu_File_InsertFood_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(172, 6);
            // 
            // Mnu_File_CustomerDef
            // 
            this.Mnu_File_CustomerDef.Image = global::FlowerShop.Properties.Resources._001_user;
            this.Mnu_File_CustomerDef.Name = "Mnu_File_CustomerDef";
            this.Mnu_File_CustomerDef.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_CustomerDef.Text = "تعریف مشتری";
            this.Mnu_File_CustomerDef.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 6);
            // 
            // Mnu_File_Factor
            // 
            this.Mnu_File_Factor.Image = global::FlowerShop.Properties.Resources.insurance;
            this.Mnu_File_Factor.Name = "Mnu_File_Factor";
            this.Mnu_File_Factor.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_Factor.Text = "فاکتور";
            this.Mnu_File_Factor.Click += new System.EventHandler(this.Mnu_File_Factor_Click);
            // 
            // chpFactorToolStripMenuItem
            // 
            this.chpFactorToolStripMenuItem.Image = global::FlowerShop.Properties.Resources._1300877789_cash_register;
            this.chpFactorToolStripMenuItem.Name = "chpFactorToolStripMenuItem";
            this.chpFactorToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.chpFactorToolStripMenuItem.Text = "چاپ فاکتور";
            this.chpFactorToolStripMenuItem.Click += new System.EventHandler(this.chpFactorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(172, 6);
            // 
            // Mnu_File_Exit
            // 
            this.Mnu_File_Exit.Image = global::FlowerShop.Properties.Resources.Exit_MnuIco;
            this.Mnu_File_Exit.Name = "Mnu_File_Exit";
            this.Mnu_File_Exit.Size = new System.Drawing.Size(175, 38);
            this.Mnu_File_Exit.Text = "خروج";
            this.Mnu_File_Exit.Click += new System.EventHandler(this.Mnu_File_Exit_Click);
            // 
            // Mnu_Security
            // 
            this.Mnu_Security.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSecurity_DefineUsers});
            this.Mnu_Security.Image = global::FlowerShop.Properties.Resources.Security_MnuIco;
            this.Mnu_Security.Name = "Mnu_Security";
            this.Mnu_Security.Size = new System.Drawing.Size(168, 36);
            this.Mnu_Security.Text = "تنظیمات امنیتی     |";
            // 
            // mnuSecurity_DefineUsers
            // 
            this.mnuSecurity_DefineUsers.Image = global::FlowerShop.Properties.Resources.Administrator_icon;
            this.mnuSecurity_DefineUsers.Name = "mnuSecurity_DefineUsers";
            this.mnuSecurity_DefineUsers.Size = new System.Drawing.Size(177, 38);
            this.mnuSecurity_DefineUsers.Text = "ویرایش کاربران";
            this.mnuSecurity_DefineUsers.Click += new System.EventHandler(this.mnuSecurity_DefineUsers_Click);
            // 
            // Mnu_Help
            // 
            this.Mnu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Help_Calculator,
            this.toolStripMenuItem1,
            this.Mnu_Help_About});
            this.Mnu_Help.Image = global::FlowerShop.Properties.Resources.Help_MnuIco;
            this.Mnu_Help.Name = "Mnu_Help";
            this.Mnu_Help.Size = new System.Drawing.Size(114, 36);
            this.Mnu_Help.Text = "ابزار کمکی";
            // 
            // Mnu_Help_Calculator
            // 
            this.Mnu_Help_Calculator.Image = global::FlowerShop.Properties.Resources._1300877789_cash_register;
            this.Mnu_Help_Calculator.Name = "Mnu_Help_Calculator";
            this.Mnu_Help_Calculator.Size = new System.Drawing.Size(195, 38);
            this.Mnu_Help_Calculator.Text = "ماشین حساب";
            this.Mnu_Help_Calculator.Click += new System.EventHandler(this.Mnu_Help_Calculator_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // Mnu_Help_About
            // 
            this.Mnu_Help_About.Image = global::FlowerShop.Properties.Resources.Borsalino_Blanc;
            this.Mnu_Help_About.Name = "Mnu_Help_About";
            this.Mnu_Help_About.Size = new System.Drawing.Size(195, 38);
            this.Mnu_Help_About.Text = "در مورد برنامه . . .";
            this.Mnu_Help_About.Click += new System.EventHandler(this.Mnu_Help_About_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 567);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(945, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources.Booo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 589);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMainMdi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم اصلی سیستم گل فروشی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMdi_FormClosed);
            this.Load += new System.EventHandler(this.frmMainMdi_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Security;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Help;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_FoodCategu;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_FoodUnit;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_FoodDef;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_CustomerDef;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuSecurity_DefineUsers;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_Factor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_InsertFood;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Help_Calculator;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Help_About;
        private System.Windows.Forms.ToolStripMenuItem chpFactorToolStripMenuItem;
    }
}



