using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Product : Form
    {
        private int id;
        public Product()
        {
            InitializeComponent();            
        }

        public Product(int id)
        {
            InitializeComponent();
            this.id = id;
            txtProductID.Text =id.ToString();
            txtProductID.ReadOnly = true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (txtProductName.Text.Trim()!="")
            if (MessageBox.Show("","",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                    e.Cancel = true;
                    saveChange();
            }
            base.OnClosing(e);
        }
        private void saveChange() {

        }
    }
}
