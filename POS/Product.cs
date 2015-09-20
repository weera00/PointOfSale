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
        private enum mode{ newdata,editdata}
        mode Mode =mode.newdata;
        public Product()
        {
            InitializeComponent();            
        }

        public Product(int id)
        {
            InitializeComponent();
            this.id = id;
            Mode = mode.editdata;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
