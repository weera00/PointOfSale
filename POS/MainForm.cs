using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "ใช่หรือไม่",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) ==DialogResult.No)
            {
                e.Cancel=true;
            }
            base.OnClosing(e);  
        }

        private void settingDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form currentform in this.MdiChildren)
            {
                if (currentform is Setting)
                {
                    currentform.WindowState = FormWindowState.Maximized;
                    currentform.MdiParent = this;
                    currentform.Show();
                    return;
                }
            }
            Setting frm = new Setting();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form currentform in this.MdiChildren)
            {
                if (currentform is ProductList)
                {
                    currentform.WindowState = FormWindowState.Maximized;
                    currentform.MdiParent = this;
                    currentform.Show();
                    return;
                }
            }
            ProductList frm = new ProductList();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void productStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form currentform in this.MdiChildren)
            {
                if (currentform is StockProduct)
                {
                    currentform.WindowState = FormWindowState.Maximized;
                    currentform.MdiParent = this;                    
                    currentform.Show();
                    return;
                }
            }
            StockProduct frm = new StockProduct();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
