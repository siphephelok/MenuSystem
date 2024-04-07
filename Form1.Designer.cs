namespace MenuSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.form4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLogIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStrip,
            this.menu2ToolStrip,
            this.logOutToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStrip
            // 
            this.menu1ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem});
            this.menu1ToolStrip.Enabled = false;
            this.menu1ToolStrip.Name = "menu1ToolStrip";
            this.menu1ToolStrip.Size = new System.Drawing.Size(68, 24);
            this.menu1ToolStrip.Text = "Menu1";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.form2ToolStripMenuItem.Text = "Form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.form3ToolStripMenuItem.Text = "Form3";
            this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
            // 
            // menu2ToolStrip
            // 
            this.menu2ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form4ToolStripMenuItem});
            this.menu2ToolStrip.Enabled = false;
            this.menu2ToolStrip.Name = "menu2ToolStrip";
            this.menu2ToolStrip.Size = new System.Drawing.Size(68, 24);
            this.menu2ToolStrip.Text = "Menu2";
            // 
            // form4ToolStripMenuItem
            // 
            this.form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            this.form4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.form4ToolStripMenuItem.Text = "Form4";
            // 
            // logOutToolStrip
            // 
            this.logOutToolStrip.Enabled = false;
            this.logOutToolStrip.Name = "logOutToolStrip";
            this.logOutToolStrip.Size = new System.Drawing.Size(72, 24);
            this.logOutToolStrip.Text = "LogOut";
            this.logOutToolStrip.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLogIn,
            this.toolStripSale,
            this.toolStripSearch});
            this.toolStrip1.Location = new System.Drawing.Point(695, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(105, 422);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLogIn
            // 
            this.toolStripLogIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLogIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLogIn.Image")));
            this.toolStripLogIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLogIn.Name = "toolStripLogIn";
            this.toolStripLogIn.Size = new System.Drawing.Size(102, 104);
            this.toolStripLogIn.Text = "toolStripButton1";
            this.toolStripLogIn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSale
            // 
            this.toolStripSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSale.Enabled = false;
            this.toolStripSale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSale.Image")));
            this.toolStripSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSale.Name = "toolStripSale";
            this.toolStripSale.Size = new System.Drawing.Size(102, 104);
            this.toolStripSale.Text = "toolStripButton2";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearch.Enabled = false;
            this.toolStripSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearch.Image")));
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(102, 104);
            this.toolStripSearch.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem form4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripLogIn;
        private System.Windows.Forms.ToolStripButton toolStripSale;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
    }
}

