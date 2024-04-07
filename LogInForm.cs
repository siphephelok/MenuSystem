using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuSystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "Siphephelo" && PasswordTextBox.Text == "Myeni")
            {
                MessageBox.Show("Welcome to the MAIN SYSTEM!!");
                Form frm = (Form)Application.OpenForms["Form1"];
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
                ms.Items["menu1ToolStrip"].Enabled = true;
                ms.Items["menu2ToolStrip"].Enabled = true;
                ms.Items["logOutToolStrip"].Enabled = true;
                ToolStrip ts = (ToolStrip)frm.Controls["toolstrip1"];
                ts.Items["toolStripLogIn"].Enabled = false;
                ts.Items["toolStripSale"].Enabled = true;
                ts.Items["toolStripSearch"].Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Log In details", "Error", MessageBoxButtons.OKCancel);
            }
        }
    }
}
