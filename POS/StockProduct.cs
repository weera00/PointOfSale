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
    public partial class StockProduct : Form
    {
        private enum mode { newdata,editdata}
        mode Mode;
        public StockProduct()
        {
            InitializeComponent();
            txtProductName.ReadOnly = true;
            Mode = mode.newdata;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearData();
            Mode = mode.newdata;
        }

        void clearData() {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductCount.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mode==mode.newdata)
            {

            }
            else if (Mode==mode.editdata)
            {

            }
        }
    }
}
