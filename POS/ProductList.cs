using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductList : Form
    {
        SqlConnection objConn = new SqlConnection();
        SqlCommand objCmd=new SqlCommand();
        SqlDataAdapter objDa=new SqlDataAdapter();
        String strConnString = @ConfigurationManager.ConnectionStrings["strConnString"].ToString();

        //private String strConnString= "Server=localhost\\SQLEXPRESS;Database=myDataBase;User Id=weera;Password=passTh;";
        
        public ProductList()
        {
            InitializeComponent();
            //strConnString = "Server=" + dbhost + "\\SQLEXPRESS;Database="+dbname+";User Id="+user+";Password="+pass+";";
            list();
        }

        private void list() {
            try
            {
                using (SqlConnection c = new SqlConnection(
                   // Properties.Settings.Default.DataConnectionString
                   strConnString)) {
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT id,name,mydate FROM dbo.product", c)) {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    datagridProductlist.DataSource = dt; 
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        protected override void OnClosing(CancelEventArgs e)
        {          
            base.OnClosing(e);
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (datagridProductlist.Rows[e.RowIndex].Cells[/*e.ColumnIndex*/0].Value!=null)
            {                
                int id =int.Parse(datagridProductlist.Rows[e.RowIndex].Cells[0].Value.ToString());
                Product frm = new Product(id);
                frm.ShowDialog();
            } 
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product frm = new Product();
            frm.ShowDialog();
        }
    }
}