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
        String strConnString= "Server=localhost\\SQLEXPRESS;Database=myDataBase;User Id=weera;Password=;";
        String strSql;

        public ProductList()
        {
            InitializeComponent();
            open();
        }
        public ProductList(SqlConnection conn) {
            InitializeComponent();
            objConn = conn;
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

        protected override void OnClosing(CancelEventArgs e)
        {
            close();
            base.OnClosing(e);
        }
    }
}