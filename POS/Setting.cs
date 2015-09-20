using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            ReadConfig();
        }
        public void ReadConfig() {
            try
            {  
                var host = ConfigurationSettings.AppSettings["dbhost"].ToString();
                var port = ConfigurationSettings.AppSettings["port"].ToString();
                var dbname = ConfigurationSettings.AppSettings["dbname"].ToString();
                var user = ConfigurationSettings.AppSettings["user"].ToString();
                var pass = ConfigurationSettings.AppSettings["pass"].ToString();

                txtDbHost.Text = host;
                txtDbPort.Text = port;
                txtDbName.Text = dbname;
                txtDbUser.Text = user;
                txtDbPass.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดผลาด "+ex.Message,"เกิดข้อผิดผลาด",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void setConfig(String host = "127.0.0.1",String port ="1433",String dbname= "myDatabase", String user = "weera",String pass = "passTh")
        {
            try
            {
                ConfigurationSettings.AppSettings["dbhost"]=host;
                ConfigurationSettings.AppSettings["port"]=port;
                ConfigurationSettings.AppSettings["dbname"] = dbname;
                ConfigurationSettings.AppSettings["user"]=user;
                ConfigurationSettings.AppSettings["pass"]=pass;
               
  
                txtDbHost.Text = host;
                txtDbPort.Text = port;
                txtDbName.Text = dbname;
                txtDbUser.Text = user;
                txtDbPass.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("มีข้อมผิดผลาดเกิดขึ้น " +ex.ToString()+" "+ ex.Message);
            }
        }

        private void cancleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void resetToDefualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("การตั้งค่าฐานข้อมูลจะเปลี่ยนแปลงกลับเป็นค่าเรื่มต้นทันที","ใช่หรือไม่",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                setConfig();
            }            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConfig(txtDbHost.Text.Trim(),txtDbPort.Text.Trim(),txtDbName.Text.Trim(),txtDbUser.Text.Trim(),txtDbPass.Text.Trim());
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (false)
            {
                e.Cancel = true;
            }
            base.OnClosing(e);            
        }       
    }
}
