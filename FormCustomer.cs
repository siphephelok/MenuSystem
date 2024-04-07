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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        public void FormSetup(Form myForm)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }
        private void form1ToolStripMenuItemSale_Click(object sender, EventArgs e)
        {
            FormSale frmSale = new FormSale();
            FormSetup(frmSale);
        }
        private void form2ToolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer frmCust = new FormCustomer();
            FormSetup(frmCust);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void FormCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
