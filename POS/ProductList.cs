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
        String dbhost = ConfigurationSettings.AppSettings["dbhost"].ToString();
        String port = ConfigurationSettings.AppSettings["port"].ToString();
        String user = ConfigurationSettings.AppSettings["user"].ToString();
        String pass = ConfigurationSettings.AppSettings["pass"].ToString();
        String dbname = ConfigurationSettings.AppSettings["dbname"].ToString();

        String strConnString= "Server=localhost\\SQLEXPRESS;Database=myDataBase;User Id=weera;Password=passTh;";
        

        String strSql;

        public ProductList()
        {
            InitializeComponent();
            strConnString = "Server=" + dbhost + "\\SQLEXPRESS;Database="+dbname+";User Id="+user+";Password="+pass+";";
            open();
            list();
        }
        
        public void open()
        {
            try
            {
            objConn.ConnectionString = strConnString;
            objConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

       }

        public void close() {
            objConn.Close();
        }
        private void list() {
            try
            {
                using (SqlConnection c = new SqlConnection(
                   // Properties.Settings.Default.DataConnectionString
                   strConnString)) {
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT id as รหัส,name as ชื่อ,mydate FROM dbo.product", c)) {
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
            close();
            base.OnClosing(e);
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (datagridProductlist.Rows[e.RowIndex].Cells[/*e.ColumnIndex*/0].Value!=null)
            {
                //MessageBox.Show(datagridProductlist.Rows[e.RowIndex].Cells[/*e.ColumnIndex*/1].Value.ToString());
                int id =int.Parse(datagridProductlist.Rows[e.RowIndex].Cells[/*e.ColumnIndex*/0].Value.ToString());
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